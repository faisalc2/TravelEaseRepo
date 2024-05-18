namespace TravelEase
{
    internal class Vehicle
    {
        private string VehicleId { get; set; }
        private string BdRegId { get; set; }
        private string VehicleType { get; set; }   //
        private string VehicleClass { get; set; }
        //private double FarePerSeat { get; set; }
        private int TotalSeats { get; set; }

        public Vehicle() { }
        public Vehicle(string vehicleId, string bdRegId, string vehicleType, string vehicleClass, /*double farePerSeat,*/ int totalSeats)
        {
            VehicleId = vehicleId;
            BdRegId = bdRegId;
            VehicleType = vehicleType;
            VehicleClass = vehicleClass;
            //FarePerSeat = farePerSeat;
            TotalSeats = totalSeats;
            //BookedSeats = 0; 
        }
    }
}
//display route