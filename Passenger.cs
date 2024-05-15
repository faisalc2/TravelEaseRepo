using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TravelEase
{
    public class Passenger : User
    {
        public int passengerID { get; set; }

        public Passenger(string fname, string lname, string nID, Date dOB, string gender, string phone, string email, string residence)
            : base(fname, lname, nID, dOB, gender, phone, email, residence)
        {
            this.passengerID += 1;
        }
    }
}
