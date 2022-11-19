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
        private int age;
        private int creditnamber = 436547547;


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

        public int Age
        {
            get { return age; }
            set
            {
                if (value == 18)
                {
                    Console.WriteLine("Возраст равен 18");
                }

                else
                {
                    Console.WriteLine("Возраст не равен");
                }
                    
                    age = value;
            }
        }


        public int CredutNamber
        {
            get { return creditnamber; } // приватное свойство , только чтение 
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



