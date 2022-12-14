using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp111
{
    // Наследование

    public class Inheritance
    {
        private string _name;
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Inheritance(string name)
        {
            Name = name;
        }


        public void Printinf()
        {
            Console.WriteLine(Name);
        }





    }

    // ключенове слова  sealed запрещает наследоваться от этого класса
    sealed class Admin 
    {

    }

    
    public class Employee : Inheritance
    {
        private int _phonenameber;

        public int PhoneNumber
        {
            get { return _phonenameber; }
            set { _phonenameber = value; }
        }

        public Employee(int _phonenameber, string name )
            :base(name)
        {
            Console.WriteLine(_phonenameber);
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


    public class Airplane : Inheritance
    {
        private string _company;

        public string Company { get { return _company; } set { _company = value; } }

        public Airplane(string type, string _compaty)
            :base(type)
        {

        }
              


    }
}
