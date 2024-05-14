using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEase
{
    internal class Launch : Vehicle
    {
        private static DateTime currentDate = DateTime.Now.Date;
        private static int currentSequence = 1;

        public Launch(string bdRegId, string vehicleClass, int totalSeats)
            : base(GenerateVehicleId(), bdRegId, "Launch", vehicleClass, /*GetFarePerSeat(vehicleClass),*/ totalSeats){}

        public static string GenerateVehicleId()
        {
            if (currentDate != DateTime.Now.Date)
            {
                currentDate = DateTime.Now.Date;
                currentSequence = 1;
            }

            string datePart = currentDate.ToString("ddMMyyyy");
            string sequencePart = currentSequence.ToString("D5"); 
            string vehicleId = $"LAUNCH-{datePart}-{sequencePart}";

            currentSequence++;

            return vehicleId;
        }

        /*private static double GetFarePerSeat(string vehicleClass)
        {
            return vehicleClass == "Deluxe" ? 300.0 : 200.0;
        }*/
    }
}
