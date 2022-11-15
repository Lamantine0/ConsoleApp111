using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp111
{
    public class UserInfo
    {
        // поле класса
        public string Name;
        public string LastName;
        public string Address;
        public byte Age;


        public void WriteInConsoleInfo(string name, string lastname , string address , byte age)
        {
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nМестонахождение: {2}\nВозраст: {3}\n", name, lastname, address, age);
        }




    }
}
