using System.Xml.Linq;

namespace TravelEase
{
    internal class Admin 
    {
        private const string _adminID = "System123";
        private const string _adminName = "Admin";

        public string AdminID 
        {
            get { return _adminID; }   
        }
        public string AdminName
        {
            get { return _adminName; }
        }

       public Admin()
        {

        }
        
    }
}
