using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEase.Moduler_Admin;

namespace TravelEase
{
    internal class Bus : Vehicle
    {
        public Bus(string vehicleName, string bdRegId, int mAdminID, int destinationID)
           : base(1, vehicleName, bdRegId, mAdminID, destinationID)
        {
        }

        // Static method to add a new Bus record
        public static void AddBus(string vehicleName, string bdRegId, string desFrom, string desTo)
        {
            // Get the MAdminID from the singleton instance
            int mAdminID = ModularAdminSingletone.Instance.currentMAdmin.GetModularAdminNumber();

            // Get or create the destinationID using the desFrom and desTo parameters
            int destinationID = GetOrCreateDestinationID(desFrom, desTo);

            // Create a new Bus instance
            Bus newBus = new Bus(vehicleName, bdRegId, mAdminID, destinationID);

            // Insert the bus record into the database
            newBus.InsertVehicleRecord();
        }
    }
}
