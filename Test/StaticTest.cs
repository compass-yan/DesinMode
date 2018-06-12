using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
   public class StaticTest
    {
       public static int x = 0;
        public void Test()
        {
            x = 99;
        }
        public int X
        {
            get
            {
                return x;
            }
        }
    }
}
