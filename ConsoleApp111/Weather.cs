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


            Random random = new Random();
            degreesCelsius = random.Next(40);
          
            if (degreesCelsius == 40)
            {

                Console.WriteLine($"{degreesCelsius} : выпейте воды");


                //var degreesCelsius1 = random.Next(-30, 40);

            }

            weatherminus = random.Next(-0);


            if (weatherminus == 1)
            {
                Console.WriteLine($"{weatherminus} Оденьте шарф");

            }

           

        }


        



    }
        
}
