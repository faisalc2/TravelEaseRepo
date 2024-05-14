namespace TravelEase
{
    internal class ModularAdmin : User
    {
        private string _modularAdminID;

        //public string ModularAdminID
        //{
        //    get { return _modularAdminID; }
        //    set { _modularAdminID = value; }
        //}

        private static DateTime currentDate = DateTime.Now.Date;
        private static int currentSequence = 1;
        private static string GenerateModularAdminId()
        {
            if (currentDate != DateTime.Now.Date)
            {
                currentDate = DateTime.Now.Date;
                currentSequence = 1;
            }

            string datePart = currentDate.ToString("ddMMyyyy");
            string sequencePart = currentSequence.ToString("D5");
            string vehicleId = $"ADM-{datePart}-{sequencePart}";

            currentSequence++;

            return vehicleId;
        }

        public ModularAdmin(string fname, string lname, string nID, DateTime dOB, string gender, int age, string phone, string email)
            :base( fname, lname, nID, dOB, gender, age, phone, email)
        {
            _modularAdminID = GenerateModularAdminId();
        }
    }
}
