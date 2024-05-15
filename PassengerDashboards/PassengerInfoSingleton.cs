using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEase.PassengerDashboards
{
    internal class PassengerInfoSingleton
    {
        private static PassengerInfoSingleton _instance;
        private static readonly object _lock = new object();

        private PassengerInfoSingleton() { }

        public static PassengerInfoSingleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PassengerInfoSingleton();
                    }
                    return _instance;
                }
            }
        }

        public Passenger CurrentPassenger { get; set; }

    }
}
