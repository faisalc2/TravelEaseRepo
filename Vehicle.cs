using System.Data.SqlClient;

namespace TravelEase
{
    internal class Vehicle
    {
        public int VehicleTypeID { get; set; }
        public string VehicleName { get; set; }
        public string BDRegistrationNumber { get; set; }
        public int MAdminID { get; set; }
        public int AvailableSeats { get; set; } = 10;
        public int VehicleStatus { get; set; } = 0;
        public int DestinationID { get; set; }

        public Vehicle(int vehicleTypeID, string vehicleName, string bDRegistrationNumber, int mAdminID, int destinationID)
        {
            VehicleTypeID = vehicleTypeID;
            VehicleName = vehicleName;
            BDRegistrationNumber = bDRegistrationNumber;
            MAdminID = mAdminID;
            DestinationID = destinationID;
        }

        public static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TravelEaseDB;Integrated Security=True";

        public static int GetOrCreateDestinationID(string desFrom, string desTo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT destinationID FROM DestinationTB WHERE desFrom = @desFrom AND desTo = @desTo", conn);
                cmd.Parameters.AddWithValue("@desFrom", desFrom);
                cmd.Parameters.AddWithValue("@desTo", desTo);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    // Insert new destination and get its ID
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO DestinationTB (desFrom, desTo) OUTPUT INSERTED.destinationID VALUES (@desFrom, @desTo)", conn);
                    insertCmd.Parameters.AddWithValue("@desFrom", desFrom);
                    insertCmd.Parameters.AddWithValue("@desTo", desTo);
                    return (int)insertCmd.ExecuteScalar();
                }
            }
        }

        public void InsertVehicleRecord()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO VehicleTB (vehicleTypeID, vehicleName, BDRegistrationNumber, MAdminID, availableSeats, vehicleStatus, destinationID) VALUES (@vehicleTypeID, @vehicleName, @BDRegistrationNumber, @MAdminID, @availableSeats, @vehicleStatus, @destinationID)", conn);
                cmd.Parameters.AddWithValue("@vehicleTypeID", VehicleTypeID);
                cmd.Parameters.AddWithValue("@vehicleName", VehicleName);
                cmd.Parameters.AddWithValue("@BDRegistrationNumber", BDRegistrationNumber);
                cmd.Parameters.AddWithValue("@MAdminID", MAdminID);
                cmd.Parameters.AddWithValue("@availableSeats", AvailableSeats);
                cmd.Parameters.AddWithValue("@vehicleStatus", VehicleStatus);
                cmd.Parameters.AddWithValue("@destinationID", DestinationID);

                cmd.ExecuteNonQuery();
            }
        }
    }
}