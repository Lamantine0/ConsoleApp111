using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp111
{
    public class Weather
    {

        public int DegreesCelsius;
        public int Weatherminus;




        public Weather(int degreesCelsius, int weatherminus)
        {

             DegreesCelsius = degreesCelsius;
             Weatherminus = weatherminus;


        }


        public  void InfoCels()
        {
            
            Random random = new Random();
            int DegreesCelsius  = random.Next(40);
            int Weatherminus = random.Next(-0);

            if (DegreesCelsius >= 40)
            {
               
                Console.WriteLine($"{DegreesCelsius} : выпейте воды");


               //var degreesCelsius1 = random.Next(-30, 40);

                if (Weatherminus == 1)
                {
                    Console.WriteLine($"{DegreesCelsius} Оденьте шарф");

                }
            }
            //Console.WriteLine(DegreesCelsius);
        }



        
    }
}
