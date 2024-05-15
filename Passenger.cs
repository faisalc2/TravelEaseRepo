using System;
using System.Data;
using System.Data.SqlClient;

namespace TravelEase
{
    public class Passenger : User
    {
        public int passengerID { get; set; }
        string QGetInfo = "select * from UserTB where @userID = UserID";
        string QGetTicketInfo = "select * from TicketTB where @userID = UserID";
        public Ticket ticket;

        public Passenger(string fname, string lname, string nID, DateTime dOB, string gender, string phone, string email, string residence, string userID)
            : base(fname, lname, nID, dOB, gender, phone, email, residence, userID)
        {
            ticket = new Ticket();
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
                        ticket.seatNumber = reader["SeatNumber"].ToString();
                        ticket.userID = reader["userID"].ToString();
                        ticket.vehicleID = (int)reader["vehicleID"];
                        ticket.buyDate = (DateTime)reader["buyDate"];
                        ticket.fare = (double)reader["fare"];
                        ticket.seatAmount = (int)reader["seatAmount"];
                    }
                }
            }
            return dt;
        }
    }
}
