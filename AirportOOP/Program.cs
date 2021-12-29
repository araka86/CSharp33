using System;

namespace AirportOOP
{
    public class Program
    {


        static void Main(string[] args)
        {
            var print = new View();
            var airline = new Airline();








            airline.Init();

         

           // print.Display(airline);


          //  print.Display(airline.airports);




            //   var flight = new Flight(
            //       DateTime.Now.AddMinutes(180), //відправка departure
            //       DateTime.Now.AddMinutes(360), //Прибуття  arrival
            //       airport2,
            //       airport2);
            //
            //   var status = flight.FlightStatus;
            //
            //
            //   flight.FlightState = FlightState.Canceled;
            //   status = flight.FlightStatus;
            //   flight.FlightState = FlightState.Delayed;
            //   flight.DepartureDateTime = flight.DepartureDateTime.AddMinutes(60);
            //   status = flight.FlightStatus;



            Console.WriteLine("Виберите действие");


            int a = Int32.Parse( Console.ReadLine());


            PanelMenu(a,print,airline);
            
           
        }

        public static object PanelMenu(int course, View data,Airline airlineData)
        {
            return course switch //свитч)
            {
                1 => data.Display2(airlineData),
                2 => ("Matlab"),
                3 => ("C#"),
                4 => ("Технологія програмування"),
                5 => ("Semantic web and XML"),
                6 => ("Парадигми програмування"),
                _ => ("Неправильно заданий курс"),
            };
        }




    }
}
