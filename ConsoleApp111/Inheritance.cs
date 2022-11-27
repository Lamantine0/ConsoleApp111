using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp111
{
    // Наследование
    public class Inheritance
    {
        private string _name = "";

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Printinf()
        {
            Console.WriteLine(Name);
        }





    }

    class Employee : Inheritance // наследование 
    {

    }
}
