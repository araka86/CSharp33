using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportOOP
{
    public class View
    {


        public void Display( Airline flight)
        {

            foreach(var fl in flight.airports) 
            {
               
                foreach(var fl2 in fl.Flights) 
                {
                  //  Console.WriteLine(fl2.DepartireAirport.Name);
                }

            }


        }


        public string Display2(Airline flight)

        {
            Console.WriteLine("Airport:\n_________________________");
            foreach (var fl in flight.airports)
            {

                
                      Console.WriteLine($"{fl.City} - {fl.Name}");
              

             
            }
            return string.Empty;

        }



        public void Display(  Airport[]  flights)
        {
            Console.WriteLine("List All Airports");

            foreach(var flight in flights) 
            {
                Console.WriteLine($"Airport : {flight.Name}\n________________________________");
                foreach (var item in flight.Flights)
                {
                    Console.WriteLine($"City отправка из  :  {item.DepartireAirport.City} ---> {item.ArrivalAirport.City} ");

                }

                Console.WriteLine();

            }

          
        }

    }
}
