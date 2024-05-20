using System;
using System.Data;
using System.Data.SqlClient;

namespace TravelEase
{
    public class Passenger : User
    {
        public int passengerID { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        string QGetInfo = "SELECT u.*, l.userName, l.userPassword FROM UserTB u JOIN LoginCredentialsTB l ON u.userID = l.userID WHERE u.userID = @userID;";
        string QGetTicketInfo = "select * from TicketTB where @userID = UserID";
        string QDeleteTicket = "DELETE FROM TicketTB WHERE @ticketID = TicketID";
        string QUpdatePassenger = @"
                        UPDATE UserTB
                        SET 
                            fName = @fName,
                            lName = @lName,
                            gender = @gender,
                            dob = @dob,
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

        public Ticket ticket;
        public Payment payment;

        public Passenger(string uname, string upass, string fname, string lname, string nID, DateTime dOB, string gender, string phone, string email, string residence, string userID)
            : base(fname, lname, nID, dOB, gender, phone, email, residence, userID)
        {
            ticket = new Ticket();
            this.userName = uname;
            this.userPassword = upass;
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



        public DataTable GetTicketInfo()
        {
            SqlDataAdapter sdt;
            DataTable dt;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(QGetTicketInfo, conn);
                cmd.Parameters.AddWithValue("@userID", UserID);
                sdt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sdt.Fill(dt);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ticket.ticketID = (int)reader["ticketID"];
                        ticket.userID = reader["userID"].ToString();
                        ticket.vehicleID = (int)reader["vehicleID"];
                        ticket.buyDate = (DateTime)reader["buyDate"];
                        ticket.fare = (double)reader["fare"];
                        ticket.seatAmount = (int)reader["seatAmount"];
                        ticket.journeyDate = (DateTime)reader["journeyDate"];
                    }
                }
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

        public bool UpdateUserDetails(Passenger p)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Update UserTB
                        SqlCommand cmdUser = new SqlCommand(QUpdatePassenger, conn, transaction);
                        cmdUser.Parameters.AddWithValue("@userID", UserID);
                        cmdUser.Parameters.AddWithValue("@fName", p.FirstName);
                        cmdUser.Parameters.AddWithValue("@lName", p.LastName);
                        cmdUser.Parameters.AddWithValue("@gender", p.Gender);
                        cmdUser.Parameters.AddWithValue("@dob", p.DateOfBirth);
                        cmdUser.Parameters.AddWithValue("@phone", p.Phone);
                        cmdUser.Parameters.AddWithValue("@email", p.Email);
                        cmdUser.ExecuteNonQuery();

                        // Update LoginCredentialsTB
                        SqlCommand cmdLogin = new SqlCommand(QupdateLoginCred, conn, transaction);
                        cmdLogin.Parameters.AddWithValue("@userID", UserID);
                        cmdLogin.Parameters.AddWithValue("@userName", p.userName);
                        cmdLogin.Parameters.AddWithValue("@userPassword", p.userPassword);
                        cmdLogin.ExecuteNonQuery();

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
    }
}
