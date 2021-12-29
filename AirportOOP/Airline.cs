using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportOOP
{
    public class Airline
    {
        public Airport[] airports;

     //   public Airport[] Airports = this.airports;

        public Airline()
        {
            
        }


        public void Init()
        {

            var egyptHurgada = new Airport("Hurgada", "Egypt");
            var londonAirport = new Airport("LondonPort", "London");
            var kievAirport = new Airport("Boruspil", "Kiev");

            this.AddAirport(londonAirport);
            this.AddAirport(kievAirport);
            this.AddAirport(egyptHurgada);

            var Yuiri = new Passenger("Yurii", "Golova", Gender.Male);
            var Yulia = new Passenger("Yliya", "Golova", Gender.Female);


            var Ruslan = new Passenger("Ruslan", "Golova", Gender.Male);
            var Yuliaa = new Passenger("Yliya", "Golova", Gender.Female);



            var londonKievFlight = new Flight(
                 DateTime.Now.AddDays(1),
                 DateTime.Now.AddDays(1).AddHours(180),
                 londonAirport,
                 kievAirport);


            var KievEgyptFlight = new Flight(
                DateTime.Now.AddDays(2),
                DateTime.Now.AddDays(2).AddHours(180),
                kievAirport, 
                egyptHurgada);

            KievEgyptFlight.AddPassenger(Ruslan);
            KievEgyptFlight.AddPassenger(Yuliaa);

            londonKievFlight.AddPassenger(Yuiri);
            londonKievFlight.AddPassenger(Yulia);
        }

        public void AddAirport(Airport airport)
        {
           

            if(this.airports == null) 
            {
                this.airports = new Airport[] { airport};
                return;
            }


            var airports = new Airport[this.airports.Length + 1];
            Array.Copy(this.airports, airports, this.airports.Length);
            airports[airports.Length - 1] = airport;

            this.airports = airports;

        }

    }



}
