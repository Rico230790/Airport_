using System;
using System.Collections.Generic;
using AirportModels.Enums;

namespace AirportModels
{
    public class FlightM
    {
        public FlightM()
        {
            Tickets = new List<Ticket>();
        }
        public int Id { get; set; }
        public int FligthId { get; set; }
        public Status FlightStatus { get; set; }
        public DateTime SourceLocationTime { get; set; }
        public DateTime DestinationTime { get; set; }
        public string SourceCity { get; set; }
        public string DestinationCity { get; set; }
        public string Gate { get; set; }
        public string Terminal { get; set; }
        public FligthStatus Status { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
