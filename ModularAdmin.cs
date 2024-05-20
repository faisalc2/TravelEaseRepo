using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Windows.Forms;

namespace TravelEase
{
    internal class ModularAdmin : User
    {
        public string userNameModular { get; set; }
        public string userPasswordModular { get; set; }
        public Ticket ticket;
        public Payment payment;
        public Company company;
        public Vehicle vehicle;
        private int persent_80, persent_60, persent_40, no_refund;
        public int Persent_80 { set { persent_80 = value; } }
        public int Persent_60 { set { persent_60 = value; } }
        public int Persent_40 { set { persent_40 = value; } }
        public int No_refund { set { no_refund = value; } }

        string QGetInfo = "SELECT u.*, l.userName, l.userPassword FROM UserTB u JOIN LoginCredentialsTB l ON u.userID = l.userID WHERE u.userID = @userID;";
        string QDeleteTicket = "DELETE FROM TicketTB WHERE @ticketID = TicketID";
        string QUpdateModularAdmin = @"
            UPDATE UserTB
            SET 
                fName = @fName,
                lName = @lName,
                phone = @phone,
                email = @email
            WHERE 
                userID = @userID";
        string QupdateLoginCred = @"
            UPDATE LoginCredentialsTB
            SET 
                userName = @userName,
                userPassword = @userPassword
            WHERE 
                userID = @userID";
        string QupdateCompany = @"
            UPDATE CompanyTB
            SET 
                compName = @companyName
            WHERE 
                companyID = (SELECT companyID FROM MAdminCompanyTB WHERE MAdminNumber = @MAdminNumber)";

        public int GetModularAdminNumber()
        {
            string QGetModularAdminNumber = "SELECT MAdminNumber FROM ModularAdminTB WHERE userID = @userID";
            int modularAdminNumber = -1; // Default value in case no result is found

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(QGetModularAdminNumber, conn);
                cmd.Parameters.AddWithValue("@userID", UserID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    modularAdminNumber = reader.GetInt32(0);
                }

                reader.Close();
            }

            return modularAdminNumber;
        }

        public DataTable GetTicketsByVehicleID(int vehicleID, out string message)
        {
            message = string.Empty;
            DataTable dataTable = new DataTable();

            string checkVehicleQuery = "SELECT COUNT(*) FROM VehicleTB WHERE vehicleID = @vehicleID AND MAdminID = @mAdminID";

            string ticketQuery = "SELECT ticketID, userID, vehicleID, buyDate, fare, seatAmount, journeyDate FROM TicketTB WHERE vehicleID = @vehicleID";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand checkVehicleCommand = new SqlCommand(checkVehicleQuery, conn))
                    {
                        checkVehicleCommand.Parameters.AddWithValue("@vehicleID", vehicleID);
                        checkVehicleCommand.Parameters.AddWithValue("@mAdminID", GetModularAdminNumber());

                        int count = (int)checkVehicleCommand.ExecuteScalar();

                        if (count == 0)
                        {
                            message = "Invalid vehicle id or this vehicle does not belong to your company.";
                            return null;
                        }
                    }

                    using (SqlCommand ticketCommand = new SqlCommand(ticketQuery, conn))
                    {
                        ticketCommand.Parameters.AddWithValue("@vehicleID", vehicleID);

                        SqlDataAdapter adapter = new SqlDataAdapter(ticketCommand);
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    message = "An error occurred: " + ex.Message;
                    return null;
                }
            }

            return dataTable;
        }

        public bool DeleteTicket(int vehicleID, int ticketID)
        {
            string query = "DELETE FROM TicketTB WHERE vehicleID = @vehicleID AND ticketID = @ticketID";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@vehicleID", vehicleID);
                    command.Parameters.AddWithValue("@ticketID", ticketID);

                    try
                    {
                        conn.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        return false;
                    }
                }
            }
        }



        public DataTable GetAllModularInfo()
        {
            int modularAdminNumber = GetModularAdminNumber();
            if (modularAdminNumber == -1)
            {
                throw new Exception("Modular Admin Number not found for the given user ID.");
            }

            string QGetAllModularInfo = @"
                SELECT u.*, l.userName, l.userPassword, c.compName
                FROM UserTB u
                JOIN LoginCredentialsTB l ON u.userID = l.userID
                LEFT JOIN ModularAdminTB ma ON u.userID = ma.userID
                LEFT JOIN MAdminCompanyTB mac ON ma.MAdminNumber = mac.MAdminNumber
                LEFT JOIN CompanyTB c ON mac.companyID = c.companyID
                WHERE u.userID = @userID AND ma.MAdminNumber = @MAdminNumber";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(QGetAllModularInfo, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", UserID);
                    cmd.Parameters.AddWithValue("@MAdminNumber", modularAdminNumber);
                    using (SqlDataAdapter sdt = new SqlDataAdapter(cmd))
                    {
                        sdt.Fill(dt);
                    }
                }
            }

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                this.FirstName = row["fName"].ToString();
                this.LastName = row["lName"].ToString();
                this.Phone = row["phone"].ToString();
                this.Email = row["email"].ToString();
                this.userNameModular = row["userName"].ToString();
                this.userPasswordModular = row["userPassword"].ToString();
                this.company = new Company() { CompanyName = row["compName"].ToString() };
            }

            return dt;
        }

        public bool UpdateMAdminDetails(ModularAdmin m)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Update UserTB
                        SqlCommand cmdMAdmin = new SqlCommand(QUpdateModularAdmin, conn, transaction);
                        cmdMAdmin.Parameters.AddWithValue("@userID", UserID);
                        cmdMAdmin.Parameters.AddWithValue("@fName", m.FirstName);
                        cmdMAdmin.Parameters.AddWithValue("@lName", m.LastName);
                        cmdMAdmin.Parameters.AddWithValue("@phone", m.Phone);
                        cmdMAdmin.Parameters.AddWithValue("@email", m.Email);
                        cmdMAdmin.ExecuteNonQuery();

                        // Update LoginCredentialsTB
                        SqlCommand cmdLogin = new SqlCommand(QupdateLoginCred, conn, transaction);
                        cmdLogin.Parameters.AddWithValue("@userID", UserID);
                        cmdLogin.Parameters.AddWithValue("@userName", m.userNameModular);
                        cmdLogin.Parameters.AddWithValue("@userPassword", m.userPasswordModular);
                        cmdLogin.ExecuteNonQuery();

                        // Update CompanyTB
                        SqlCommand cmdCompany = new SqlCommand(QupdateCompany, conn, transaction);
                        cmdCompany.Parameters.AddWithValue("@companyName", m.company.CompanyName);
                        cmdCompany.Parameters.AddWithValue("@MAdminNumber", GetModularAdminNumber());
                        cmdCompany.ExecuteNonQuery();

                        // Commit transaction
                        transaction.Commit();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction if any error occurs
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public ModularAdmin(string uname, string upass, string fname, string lname, string nID, DateTime dOB, string gender, string phone, string email, string residence, string userID)
            : base(fname, lname, nID, dOB, gender, phone, email, residence, userID)
        {
            this.ticket = new Ticket();
            this.company = new Company();
            //this.vehicle = new Vehicle();

            this.userNameModular = uname;
            this.userPasswordModular = upass;
        }

        public bool CancelTicket(int ticketID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(QDeleteTicket, conn);
                    cmd.Parameters.AddWithValue("@ticketID", ticketID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }


        public DataTable TripInfoShow()
        {
            DataTable dt = new DataTable();
            int modularAdminNumber = GetModularAdminNumber();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                // Query to get VehicleID and destinationID for the given MAdminNumber
                string vehicleQuery = "SELECT vehicleID, destinationID FROM VehicleTB WHERE MAdminID = @MAdminNumber";
                List<int> vehicleIds = new List<int>();

                using (SqlCommand cmd = new SqlCommand(vehicleQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MAdminNumber", modularAdminNumber);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            vehicleIds.Add(reader.GetInt32(0));
                        }
                    }
                }

                if (vehicleIds.Count > 0)
                {
                    string ids = string.Join(",", vehicleIds);
                    string detailsQuery = $@"
                SELECT d.desFrom, d.desTo, v.vehicleID 
                FROM DestinationTB d 
                JOIN VehicleTB v ON d.destinationID = v.destinationID 
                WHERE v.vehicleID IN ({ids})";

                    using (SqlCommand cmd = new SqlCommand(detailsQuery, conn))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        sda.Fill(dt);
                    }
                }

                conn.Close();
            }

            return dt;

        }

        public DataTable RefundRuleShow()
        {
            int modularAdminNumber = GetModularAdminNumber();
            string queryRefund = "SELECT * FROM RefundRuleTB WHERE MAdminNumber = @MAdminNumber";
            DataTable dt = new DataTable();

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TravelEaseDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(queryRefund, conn))
                    {
                        cmd.Parameters.AddWithValue("@MAdminNumber", modularAdminNumber);
                        SqlDataAdapter sdt = new SqlDataAdapter(cmd);
                        sdt.Fill(dt);
                    }
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return dt;
        }
        
        public bool IsModularAdminNumberExists()
        {
            int modularAdminNumber = GetModularAdminNumber();
            string query = "SELECT COUNT(*) FROM RefundRuleTB WHERE MAdminNumber = @MAdminNumber";

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MAdminNumber", modularAdminNumber);
                    int count = (int)cmd.ExecuteScalar();
                    conn.Close();
                    return count > 0;
                }
            }
        }

        public void InsertRefundRule()
        {
            string query = "INSERT INTO RefundRuleTB (refund_80_percent, refund_60_percent, refund_40_percent, no_refund, MAdminNumber) " +
                      "VALUES (@refund80Percent, @refund60Percent, @refund40Percent, @noRefund, @mAdminNumber)";

            int modularAdminNumber = GetModularAdminNumber();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@refund80Percent", persent_80);
                    cmd.Parameters.AddWithValue("@refund60Percent", persent_60);
                    cmd.Parameters.AddWithValue("@refund40Percent", persent_40);
                    cmd.Parameters.AddWithValue("@noRefund", no_refund);
                    cmd.Parameters.AddWithValue("@mAdminNumber", modularAdminNumber);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public bool RefundRuleUpdate(ModularAdmin MA)
        {
            string query = @"
        UPDATE RefundRuleTB
        SET refund_80_percent = @Refund80Percent,
            refund_60_percent = @Refund60Percent,
            refund_40_percent = @Refund40Percent,
            no_refund = @NoRefund
        WHERE MAdminNumber = @MAdminNumber";
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TravelEaseDB;Integrated Security=True";

            int modularAdminNumber = GetModularAdminNumber();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Refund80Percent", persent_80);
                cmd.Parameters.AddWithValue("@Refund60Percent", persent_60);
                cmd.Parameters.AddWithValue("@Refund40Percent", persent_40);
                cmd.Parameters.AddWithValue("@NoRefund", no_refund);
                cmd.Parameters.AddWithValue("@MAdminNumber", modularAdminNumber);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Update successful.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("No rows affected. Please check the MAdminNumber.");
                        return false;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
