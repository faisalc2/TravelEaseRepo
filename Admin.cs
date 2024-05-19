using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;
using System.Drawing;

namespace TravelEase
{
    public class Admin 
    {
        private const string _adminID = "System123";
        private const string _adminName = "Admin";
        private const string _adminPassword = "Admin123";

        public string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog = TravelEaseDB; Integrated Security = True";
        
        public string AdminID 
        {
            get { return _adminID; }   
        }
        public  string AdminName
        {
            get { return _adminName; }
        }
        public string AdminPassword
        {
            get { return _adminPassword; }
        }

       public Admin() { }
       
        public DataTable GetSomeUserInfo()
        {
            DataTable dt = new DataTable();
            string QGetSomeUserInfo = "select userID, fname, lName,phone from UserTB WHERE userStatus = 1";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(QGetSomeUserInfo, connection);
                sda.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public DataTable GetCompanyDetails()
        {
            DataTable dt = new DataTable();
            string QGetSomeUserInfo = "select companyID, compName, bdRegID from CompanyTB WHERE companyStatus = 0";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(QGetSomeUserInfo, connection);
                sda.Fill(dt);
                conn.Close();
            }
            return dt;
        }

       public DataTable GetVehicleInfo()
        {
            string query = "SELECT vehicleID, vehicleName, BDRegistrationNumber FROM VehicleTB WHERE vehicleStatus = 1";
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter sdt = new SqlDataAdapter(cmd);
                    sdt.Fill(dt);
                }
                conn.Close();
            }
            return dt;
        }
    }
}
