using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportOOP
{
    public class Airport
    {

      

        public string Name { get; set; }
        public string City { get; set; }
      
        public Flight[] Flights { get; set; }
        public Airport(string name,string city)
        {
            
            this.Name = name;
            this.City = city;
            this.Flights = new Flight[] {};
        }

       public void AddFlight(Flight flight) 
        {


            flight.Gate = new Random().Next(10);
            flight.TerminalName = $"{flight.Gate}A";

            var flights = new Flight[this.Flights.Length + 1];
            Array.Copy(this.Flights, flights, this.Flights.Length);
            flights[flights.Length - 1] = flight;

            this.Flights = flights;


        }


    }
}
