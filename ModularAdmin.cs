using System.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        //string QGetTicketInfo = "select * from TicketTB where @userID = UserID";
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
                            bdRegID = @bdRegID;
                            companyName = @companyName;
                        WHERE 
                            companyID = @companyID";
        public DataTable GetAllModularInfo()
        {
            SqlDataAdapter sdt;
            DataTable dt;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(QGetInfo, conn);
                cmd.Parameters.AddWithValue("@userID", UserID);
                sdt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sdt.Fill(dt);
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

                        //Update CompanyTB
                        SqlCommand cmdCompany = new SqlCommand(QupdateCompany, conn, transaction);
                        cmdCompany.Parameters.AddWithValue("@companyID", company.CompanyID);
                        cmdCompany.Parameters.AddWithValue("@bdRegID", company.BDRegID);
                        cmdCompany.Parameters.AddWithValue("@companyName", company.CompanyName);

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

        /*private string _modularAdminID;
        private static DateTime currentDate = DateTime.Now.Date;
        private static int currentSequence = 1;


        private static string GenerateModularAdminId()
        {
            if (currentDate != DateTime.Now.Date)
            {
                currentDate = DateTime.Now.Date;
                currentSequence = 1;
            }

            string datePart = currentDate.ToString("ddMMyyyy");
            string sequencePart = currentSequence.ToString("D5");
            string vehicleId = $"ADM-{datePart}-{sequencePart}";

            currentSequence++;

            return vehicleId;
        }
*/
        public ModularAdmin(string uname, string upass, string fname, string lname, string nID, DateTime dOB, string gender, string phone, string email, string residence, string userID)
            : base(fname, lname, nID, dOB, gender, phone, email, residence, userID)
        {
            this.ticket = new Ticket();
            this.company = new Company();
            this.vehicle = new Vehicle();

            this.userNameModular = uname;
            this.userPasswordModular = upass;
        }

        public DataTable GetAllInfo()
        {
            SqlDataAdapter sdt;
            DataTable dt;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(QGetInfo, conn);
                cmd.Parameters.AddWithValue("@userID", UserID);
                sdt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sdt.Fill(dt);
            }
            return dt;
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
                MessageBox.Show("An error occured!");
                return false;
            }
        }
    }
}
