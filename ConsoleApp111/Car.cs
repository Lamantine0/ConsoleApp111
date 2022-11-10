using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp111
{
    public class Car
    {
        public string Wheel1;
        public string Wheel2;

        public Car(string wheel1 , string wheel2)
        {
            Wheel1 = wheel1;
            Wheel2 = wheel2;

            

        }

        public void Print() => Console.WriteLine($"колесо:{Wheel1}. колесо:{Wheel2}");


        public void Deconstruct(out string wheelOne, out string wheelTwo)
        {
            wheelOne = Wheel1;
            wheelTwo = Wheel2;
        }


    }
}
