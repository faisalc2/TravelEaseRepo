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
        private DateTime _DOB;
        private string _gender;
        private string _phone;
        private string _email;
        private string _residence;
        public string connection = @"Data Source=.\SQLEXPRESS;Initial Catalog = TravelEaseDB; Integrated Security = True";

        public string FirstName
        {
            get { return _fname; }
            set { _fname = value; }
        }

        public string LastName
        {
            get { return _lname; }
            set { _lname = value; }
        }

        public string UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public string NID
        {
            get { return _NID; }
            set { _NID = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _DOB; }
            set { _DOB = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Residence
        {
            get { return _residence; }
            set { _residence = value; }
        }

        private static DateTime currentDate = DateTime.Now.Date;
        private static int currentSequence = 1;
        public User(string fname, string lname, string nID, DateTime dOB, string gender, string phone, string email, string residence, string userID)
        {
            _fname = fname;
            _lname = lname;
            _userID = userID;
            UserID = _userID;
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
