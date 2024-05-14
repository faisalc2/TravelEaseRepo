namespace TravelEase
{
    internal abstract class Vehicle
    {
        public string VehicleId { get; set; }
        public string BdRegId { get; set; }
        public string VehicleType { get; set; }
        public string VehicleClass { get; set; }
        public double FarePerSeat { get; set; }
        public int TotalSeats { get; set; }
        public int BookedSeats { get; set; }

        public Vehicle(string vehicleId, string bdRegId, string vehicleType, string vehicleClass, double farePerSeat, int totalSeats)
        {
            VehicleId = vehicleId;
            BdRegId = bdRegId;
            VehicleType = vehicleType;
            VehicleClass = vehicleClass;
            FarePerSeat = farePerSeat;
            TotalSeats = totalSeats;
            BookedSeats = 0; 
        }
    }
}
