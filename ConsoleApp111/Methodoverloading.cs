using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp111
{     
        // тема перегрузка методов
     public class Methodover
     {
        public int Width;
        public int Length;
        public int Height;


        public void ExpandSize(int width, int length, int height)
        {
            Width = width;
            Length = length;
            Height = height;
        }

        // перегрузка метода одын
        public void ExpandSize(double width, double length, double height)
        {
            var result = width + length + height;
            Console.WriteLine(result);
        }
        // перегрузка метода дваы
        public void ExpandSize(string width, string lenght)
        {
            var result1 = width + lenght;
            Console.WriteLine(result1);

        }
       

        



     }
}
