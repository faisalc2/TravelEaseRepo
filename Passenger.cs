using System;
using System.Data;
using System.Data.SqlClient;

namespace TravelEase
{
    public class Passenger : User
    {
        public int passengerID { get; set; }
        string QGetInfo = "select * from UserTB where @userID = UserID";
        string QGetTicketInfo = "select * from TicketTB where UserID = @userID";

        public Passenger(string fname, string lname, string nID, DateTime dOB, string gender, string phone, string email, string residence, string userID)
            : base(fname, lname, nID, dOB, gender, phone, email, residence, userID)
        {
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



        public Ticket GetTicketInfo()
        {
            SqlDataAdapter sdt;
            DataTable dt;
            Ticket ticket = new Ticket();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                //SqlCommand cmd = new SqlCommand(QGetTicketInfo, conn);
                //cmd.Parameters.AddWithValue("@userID", UserID);
                /*using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ticket.SerialNumber = reader["SerialNumber"].ToString();
                        ticket.PassengerInfo = reader["PassengerInfo"].ToString();
                        ticket.SeatNumber = Convert.ToInt32(reader["SeatNumber"]);
                        ticket.Fare = Convert.ToInt32(reader["Fare"]);
                        ticket.SeatAmount = Convert.ToInt32(reader["SeatAmount"]);
                    }
                }*/

                /*using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(QGetInfo, conn);
                    cmd.Parameters.AddWithValue("@userID", UserID);
                    sdt = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    sdt.Fill(dt);
                }
                return dt;*/
            }
            return ticket;
        }
    }
}
