using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp111
{
    // Тема: Полиморфизм 
    public class Wood
    {
        public string WoodType { get; set; }

        public virtual void  SeedVillage()
        {
            Console.WriteLine("Семечко");
        }

    }

    public class Oak : Wood 
    {
        public override void SeedVillage()
        {
            Console.WriteLine("Семечко Дуба");
        }

    }


    public class BirchTree : Wood
    {
        public override void SeedVillage()
        {
            Console.WriteLine("Семечко Березы");
        }
    }


    public class Cedar : Wood 
    {
        public override void SeedVillage()
        {
            Console.WriteLine("Семечко Кедра");
        }

    }
}
