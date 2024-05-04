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

        public void CalculateAge()
        {
            _age = 0;
        }
    }
}
