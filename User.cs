using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TravelEase
{
    public class User
    {
        private string _fname;
        private string _lname;
        private string _userID;
        private string _NID;
        private Date _DOB;
        private string _gender;
        private string _phone;
        private string _email;
        private string _residence;

        private static DateTime currentDate = DateTime.Now.Date;
        private static int currentSequence = 1;
        public User(string fname, string lname, string nID, Date dOB, string gender, string phone, string email, string residence)
        {
            _fname = fname;
            _lname = lname;
            _userID = GenerateModularAdminId();
            _NID = nID;
            _DOB = dOB;
            _gender = gender;
            _phone = phone;
            _email = email;
            _residence = residence;
        }

        private static string GenerateModularAdminId()
        {
            if (currentDate != DateTime.Now.Date)
            {
                currentDate = DateTime.Now.Date;
                currentSequence = 1;
            }

            string datePart = currentDate.ToString("ddMMyyyy");
            string sequencePart = currentSequence.ToString("D5");
            string vehicleId = $"user-{datePart}-{sequencePart}";

            currentSequence++;

            return vehicleId;
        }

    }
}
