using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp111
{
    public class Weather
    {
        



        public Weather()
        {
                Random random = new Random();
                var degreesCelsius = random.Next(-30, 40);

            if (degreesCelsius > 40)
            {

                Console.WriteLine($"{degreesCelsius} : выпейте воды");

                var degreesCelsius1 = random.Next(-30, 40);

                if (degreesCelsius1 <= -30)
                {
                    Console.WriteLine($"{degreesCelsius} Оденьте шарф");
                }

            }

            

           


            

            

        }














    }
}

