using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TravelEase
{
    public class Passenger : User
    {
        public int passengerID { get; set; }
        string QGetInfo = "select * from UserTB where @userID = UserID";

        public Passenger(string fname, string lname, string nID, DateTime dOB, string gender, string phone, string email, string residence, string userID)
            : base(fname, lname, nID, dOB, gender, phone, email, residence, userID)
        {
        }

        public DataTable GetAllInfo()
        {
            SqlDataAdapter sdt;
            DataTable dt;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand(QGetInfo, conn);
                using (cmd)
                {
                    cmd.Parameters.AddWithValue("@userID", UserID);
                    sdt = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    sdt.Fill(dt);
                }
            }
            conn.Close();
            return dt;
        }
    }
}
