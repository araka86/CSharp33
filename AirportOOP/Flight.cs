using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportOOP
{
    public class Flight
    {

        public string FlightNumber { get; }

        public string TerminalName { get; set; }
        public int Gate { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public FlightState FlightState { get; set; }

        public FlightStatus FlightStatus
        {
            get
            {
                if (FlightState == FlightState.Canceled)
                    return FlightStatus.Canceled;

                if (DateTime.Now >= this.ArrivalDateTime)
                    return FlightStatus.Arrived;

                if (DateTime.Now >= this.DepartureDateTime)
                    return FlightStatus.Departed;

                var chk = this.DepartureDateTime.AddMinutes(-60);
                if (DateTime.Now >= this.DepartureDateTime.AddMinutes(-60))
                    return FlightStatus.Boarding;                               //статус посадки


                if (DateTime.Now >= this.DepartureDateTime.AddMinutes(-180))
                    return FlightStatus.CheckIn;                                //стватус проверки

                if (FlightState == FlightState.Delayed)
                    return FlightStatus.Delayed;

                return FlightStatus.Created;
            }


        }
        public Airport DepartireAirport { get; set; } // аеропорт відправки

        public Airport ArrivalAirport { get; set; } // аеропорт приубцття
        public Passenger[] Passengers { get; set; }

        public Flight(
            DateTime departureDateTime,      //відправка
            DateTime arrivalDateTime,        //Прибуття
            Airport departireAirport,
            Airport arrivalAirport)
        {
            this.FlightNumber = Guid.NewGuid().ToString();
            this.DepartureDateTime = departureDateTime;
            this.ArrivalDateTime = arrivalDateTime;
            this.DepartireAirport = departireAirport;
            this.ArrivalAirport = arrivalAirport;
            this.ArrivalAirport.AddFlight(this);
            this.DepartireAirport.AddFlight(this);
            this.Passengers = new Passenger[] { };
        }


        public void AddPassenger(Passenger passenger)
        {

            var passengers = new Passenger[this.Passengers.Length + 1];
            Array.Copy(this.Passengers, passengers, this.Passengers.Length);
            passengers[passengers.Length - 1] = passenger;

            this.Passengers = passengers;
        }
    }



}
