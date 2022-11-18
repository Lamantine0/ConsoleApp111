using System;

namespace ConsoleApp111
{
    class Program
    {




        static void Main(string[] args)
        {

            Characters characters = new Characters("Ludmilla", "Tetra", "Unlimited", "Snow Phantom");
            characters.PrintInfo();


            Person bob = new Person();
            Person tom = new Person("Tom");
            Person sam = new Person("sam", 55);

            Weather weather = new Weather(40, 1);
            //weather.InfoCels();

            // создание объекта 
            UserInfo userInfo = new UserInfo();

            // вызов метода WriteInConsoleInfo внутри класса UserInfo
            userInfo.WriteInConsoleInfo("Dima", "Tereshko", "myAddres", 27);


            Properties properties = new Properties();

            Console.WriteLine(properties.Age); // вызов объекта через консоль 
            properties.Age = 777; // присваение ногово значения , отрабатывание 

            Item item = new Item(); // создания объекта 
            item.Color = "Blue"; // присвоение значения 
            Console.WriteLine(item.Color);


            Item item1 = new Item();
            item1.FullName = "Tom Tom";
            Console.WriteLine(item1.FullName);


            Item item2 = new Item();
            Console.WriteLine(item2.Birth);









            bob.Print();
            tom.Print();
            sam.Print();

            Car car = new Car("номер №1", "номер №2");

            car.Print();

            Car car1 = new Car("ddddd", "aaaaaa");


            //(_, string wheel2) = car1;

            //Console.WriteLine(wheel1);
            //Console.WriteLine(wheel2);



        }
    }
}