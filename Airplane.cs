using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEase
{
    internal class Airplane : Vehicle
    {
        private static DateTime currentDate = DateTime.Now.Date;
        private static int currentSequence = 1;

        public Airplane(string bdRegId, string vehicleClass, int totalSeats)
            : base(GenerateVehicleId(), bdRegId, "Airplane", vehicleClass, /*GetFarePerSeat(vehicleClass), */totalSeats){}

        private static string GenerateVehicleId()
        {
            if (currentDate != DateTime.Now.Date)
            {
                currentDate = DateTime.Now.Date;
                currentSequence = 1;
            }

            string datePart = currentDate.ToString("ddMMyyyy");
            string sequencePart = currentSequence.ToString("D5"); 
            string vehicleId = $"AIRPLANE-{datePart}-{sequencePart}";

            currentSequence++;

            return vehicleId;
        }

        /*private static double GetFarePerSeat(string vehicleClass)
        {
            return vehicleClass == "Business" ? 500.0 : 300.0;
        }*/
    }
}
