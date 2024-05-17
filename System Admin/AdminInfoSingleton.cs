using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEase.System_Admin
{
    internal class AdminInfoSingleton
    {
        private static AdminInfoSingleton _instance;
        private static readonly object _lock = new object();

        private AdminInfoSingleton() { }

        public static AdminInfoSingleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new AdminInfoSingleton();
                    }
                    return _instance;
                }
            }
        }

        public Admin CurrentAdmin { get; set; }
    }
}
