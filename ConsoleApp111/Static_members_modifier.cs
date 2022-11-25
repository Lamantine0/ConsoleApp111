using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp111
{
    class Static_members_modifier

    {
       
        static int OrdNumber = 0;

        static public int GetOrdNumber()
        {
            
            return OrdNumber;
        }


        public Static_members_modifier()
        {
           
            OrdNumber++;
        }
        
    }
}
