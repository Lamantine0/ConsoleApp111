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

        // в методе Printinf нельзя обратится к переменной _name т.к она с модификтором private и доступна только в родительском классе   
        public void Printinf()
        {
            Console.WriteLine(Name);
        }





    }

    // ключенове слова  sealed запрещает наследоваться от этого класса
    sealed class Admin : Inheritance
    {

    }


    class Employee : Inheritance // наследование 
    {
        public void Printinf() // метод выводит на консоль свойства класса родителя
        {
            Console.WriteLine(Name);
        }

    }


    public class Aircraft
    {
        public string Type { get; set; }

        public Aircraft(string type)
        {
            Type = type;
        }

        public void DisplayType()
        {
            Console.Write(Type);
        }
    }
}
