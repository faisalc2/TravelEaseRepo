using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEase
{
    internal class User
    {
        private string _fname;
        private string _lname;
        private string _userID;
        private string _NID;
        private DateTime _DOB;
        private string _gender;
        private int _age;
        private string _phone;
        private string _email;

        private static DateTime currentDate = DateTime.Now.Date;
        private static int currentSequence = 1;
        public User(string fname, string lname,  string nID, DateTime dOB, string gender, int age, string phone, string email)
        {
            _fname = fname;
            _lname = lname;
            _userID = GenerateModularAdminId();
            _NID = nID;
            _DOB = dOB;
            _gender = gender;
            _age = age;
            _phone = phone;
            _email = email;
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
