using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEase
{
    internal class Train : Vehicle
    {
        private static DateTime currentDate = DateTime.Now.Date;
        private static int currentSequence = 1;

        public Train(string bdRegId, string vehicleClass, int totalSeats)
        : base(GenerateVehicleId(), bdRegId, "Train", vehicleClass, /*GetFarePerSeat(vehicleClass),*/ totalSeats)
        {}

        public static string GenerateVehicleId()
        {
            if (currentDate != DateTime.Now.Date)
            {
                currentDate = DateTime.Now.Date;
                currentSequence = 1;
            }

            string datePart = currentDate.ToString("ddMMyyyy");
            string sequencePart = currentSequence.ToString("D5"); 
            string vehicleId = $"TRAIN-{datePart}-{sequencePart}";

            currentSequence++;

            return vehicleId;
        }

        /*public static double GetFarePerSeat(string vehicleClass)
        {
            return vehicleClass == "AC" ? 200.0 : 100.0;
        }*/
    }
}
