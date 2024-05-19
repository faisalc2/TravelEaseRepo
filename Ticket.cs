using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEase
{
    public class Ticket
    {
        public int ticketID { get; set; }
        public string seatNumber { get; set; }
        public string userID { get; set; }
        public int vehicleID { get; set; }
        public DateTime buyDate { get; set; }
        public DateTime journeyDate { get; set; }
        public double fare { get; set; }
        public int seatAmount { get; set; }
        public string vehicleClass { get; set; }
        public int vehicleType { get; set; }
        public int desID { get; set; }

        public Ticket() { }


    }
}
