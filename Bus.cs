using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEase
{
    internal class Bus : Vehicle
    {
        private static DateTime currentDate = DateTime.Now.Date;
        private static int currentSequence = 1;

        public Bus(string bdRegId, string vehicleClass, int totalSeats)
            : base(GenerateVehicleId(), bdRegId, "Bus", vehicleClass, GetFarePerSeat(vehicleClass), totalSeats)
        {}

        private static string GenerateVehicleId()
        {
            if (currentDate != DateTime.Now.Date)
            {
                currentDate = DateTime.Now.Date;
                currentSequence = 1;
            }

            string datePart = currentDate.ToString("ddMMyyyy");
            string sequencePart = currentSequence.ToString("D5"); 
            string vehicleId = $"BUS-{datePart}-{sequencePart}";

            currentSequence++;

            return vehicleId;
        }

        private static double GetFarePerSeat(string vehicleClass)
        {
            return vehicleClass == "AC" ? 100.0 : 50.0;
        }
    }
}
