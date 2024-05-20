using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEase.Moduler_Admin;

namespace TravelEase
{
    internal class Train : Vehicle
    {
        public Train(string vehicleName, string bdRegId, int mAdminID, int destinationID)
            : base(2, vehicleName, bdRegId, mAdminID, destinationID)
        {
        }

        // Static method to add a new Train record
        public static void AddTrain(string vehicleName, string bdRegId, string desFrom, string desTo)
        {
            // Get the MAdminID from the singleton instance
            int mAdminID = ModularAdminSingletone.Instance.currentMAdmin.GetModularAdminNumber();

            // Get or create the destinationID using the desFrom and desTo parameters
            int destinationID = GetOrCreateDestinationID(desFrom, desTo);

            // Create a new Train instance
            Train newTrain = new Train(vehicleName, bdRegId, mAdminID, destinationID);

            // Insert the train record into the database
            newTrain.InsertVehicleRecord();
            newTrain.InsertSeats();

        }
    }
}
