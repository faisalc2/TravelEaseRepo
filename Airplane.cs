using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEase.Moduler_Admin;

namespace TravelEase
{
    internal class Airplane : Vehicle
    {
        public Airplane(string vehicleName, string bdRegId, int mAdminID, int destinationID)
            : base(4, vehicleName, bdRegId, mAdminID, destinationID)
        {
        }

        // Static method to add a new Airplane record
        public static void AddAirplane(string vehicleName, string bdRegId, string desFrom, string desTo)
        {
            // Get the MAdminID from the singleton instance
            int mAdminID = ModularAdminSingletone.Instance.currentMAdmin.GetModularAdminNumber();

            // Get or create the destinationID using the desFrom and desTo parameters
            int destinationID = GetOrCreateDestinationID(desFrom, desTo);

            // Create a new Airplane instance
            Airplane newAirplane = new Airplane(vehicleName, bdRegId, mAdminID, destinationID);

            // Insert the airplane record into the database
            newAirplane.InsertVehicleRecord();
        }
    }
}
