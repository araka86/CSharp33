using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportOOP
{
    public enum FlightClass 
    {
        Busines,
        Economy
    }

    public enum Gender
    {
        Male,
        Female,
        Unisex
    }
    public class Passenger
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Nationality { get; set; }
        public string Passport { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public FlightClass FlightClass { get; set; }



        public Passenger( string firstName,string secondName,Gender gender)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Gender = gender;

        }

    }

   
}
