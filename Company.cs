using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEase
{
    internal class Company
    {
        public string CompanyID { get; set; }
        public string BDRegID { get; set; } 
        public string CompanyName { get; set;}
        public string CompanyType { get; set;}

        public Company() { }
        public Company (string cID, string bdRegID, string cName, string cType)
        {
            CompanyID = cID;
            BDRegID = bdRegID;
            CompanyName = cName;
            CompanyType = cType;
        }
    }
}
