using System;
using System.Data;
using System.Data.SqlClient;
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
            this.vehicle = new Vehicle();

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
    }
}
