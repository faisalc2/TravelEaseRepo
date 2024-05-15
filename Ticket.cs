using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEase
{
    public class Ticket
    {
        private string _serialNumber;
        private string _passengerInfo;
        private int _seatNumber;
        private int _fair;
        private int _seatAmount;

        //public Ticket ()

        public string SerialNumber { get; set; }
        public string PassengerInfo { get; set; }
        public int SeatNumber { get; set; }
        public int Fare { get; set; }
        public int SeatAmount { get; set; }

    }
}
