using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEase
{
    public class Ticket
    {
        //private int _serialNumber;
        //private string _passengerInfo;
        //private int _seatNumber;
        //private int _fair;
        //private int _seatAmount;
        public int ticketID { get; set; }
        public string seatNumber { get; set; }
        public string userID { get; set; }
        public int vehicleID { get; set; }
        public DateTime buyDate { get; set; }
        public double fare { get; set; }
        public int seatAmount { get; set; }

        public Ticket() { }
    }
}
