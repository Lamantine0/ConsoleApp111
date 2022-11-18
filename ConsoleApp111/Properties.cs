using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp111
{
    public class Item
    {
        private string color;
        private string fullname = "Sheldon Cooper";
        private int birth = 1995;

        public string Color
        {
            get { return color; } // get чтение и вовращения поля 
            set { color = value; } // set запись в поле 
        }

        public string FullName
        {
            get { return fullname.ToUpper(); }

            set
            {  if (value == "Sheldon Cooper")
                    fullname = value;

            }
        }

        public int Birth
        {
            get { return birth; }
            private set { birth = value; }
        }

        public Item() // изменение set через конструктор класса 
        {
            Birth = 2000;  // изменения значения поля
        }


    }

    
    
    public class Properties
    {
         int age = 1; 

        public int Age
        {
            set
            {
                if (value < 1 || value > 120)
                {
                    Console.WriteLine("Возраст должен быть в диапазоне от 1 до 120");
                }

                else
                {
                   age = value;
                }

            }
            get { return age; }
            

            
        }
 
 
  
    
    }
}



