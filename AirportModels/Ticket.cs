using AirportModels.Enums;

namespace AirportModels
{
    public class Ticket
    {
        public int Id { get; set; }
        public int FlightId { get; set; }
        public double Price { get; set; }
        public FlightClass FlightClass { get; set; }
        public virtual FlightM FlightM { get; set; }
        public virtual Passenger Passenger { get; set; }
    }
}
