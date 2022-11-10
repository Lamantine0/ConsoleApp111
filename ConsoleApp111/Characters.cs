using System;

namespace ConsoleApp111

{
    public class Characters
    {
        public string FullName;
        public string Manufacturer;
        public string Squad;
        public string WeaponName;

       
        public Characters(string fullname , string manufacturer , string squad , string weaponname)
        {
            FullName = fullname;
            Manufacturer = manufacturer;
            Squad = squad;
            WeaponName = weaponname;

            
           
        }


        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {FullName}\nПроизводитель: {Manufacturer}\nКоманда: {Squad}\nОружие: {WeaponName}");
        }





    }

    
} 



