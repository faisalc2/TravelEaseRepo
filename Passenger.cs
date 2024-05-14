namespace TravelEase
{
    internal class Passenger : User
    {
        public Passenger(string fname, string lname, string nID, DateTime dOB, string gender, int age, string phone, string email) 
            : base(fname,lname,nID,dOB,gender,age,phone,email)
        { }
        public string passengerID {  get; set; }
        public string passengerName { get; set;}
        public string passengerGender { get; set;}
    }
}
