using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEase.Moduler_Admin;

namespace TravelEase
{
    internal class Launch : Vehicle
    {
        public Launch(string vehicleName, string bdRegId, int mAdminID, int destinationID)
            : base(3, vehicleName, bdRegId, mAdminID, destinationID)
        {
        }

        // Static method to add a new Launch record
        public static void AddLaunch(string vehicleName, string bdRegId, string desFrom, string desTo)
        {
            // Get the MAdminID from the singleton instance
            int mAdminID = ModularAdminSingletone.Instance.currentMAdmin.GetModularAdminNumber();

            // Get or create the destinationID using the desFrom and desTo parameters
            int destinationID = GetOrCreateDestinationID(desFrom, desTo);

            // Create a new Launch instance
            Launch newLaunch = new Launch(vehicleName, bdRegId, mAdminID, destinationID);

            // Insert the launch record into the database
            newLaunch.InsertVehicleRecord();
        }
    }
}
