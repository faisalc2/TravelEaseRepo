using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEase
{
    internal class Fair : Ticket
    {
        private double _perKmCost = 1.5;
        public double calculateFair(double km)
        {
            return _perKmCost * km;
        }

    }
}
