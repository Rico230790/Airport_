using System;
using AirportModels.Enums;

namespace AirportModels
{
    public class Passenger
    {
        public int Id { get; set; }
        public Gender Gender { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime BirthDat { get; set; }
        public string Pasport { get; set; }
        public string Nationality { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
