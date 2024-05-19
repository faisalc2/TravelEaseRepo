using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelEase.PassengerDashboards;

namespace TravelEase.Moduler_Admin
{
    internal class ModularAdminSingletone
    {
        private static ModularAdminSingletone _instance;
        private static readonly object _lock = new object();

        private ModularAdminSingletone() { }

        public static ModularAdminSingletone Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new ModularAdminSingletone();
                    return _instance;
                }
            }
        }

        public ModularAdmin currentMAdmin { get; set; }
    }
}
