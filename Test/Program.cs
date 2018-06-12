using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadonlyTest rs = new ReadonlyTest(1,2);
            //Console.WriteLine($"y:{rs.y}");
            //ReadonlyTest rs2 = new ReadonlyTest(88);
            //Console.WriteLine($"y:{rs2.y}");
            //Console.ReadKey();


            StaticTest st = new StaticTest();
            Console.WriteLine(st.X);
            st.Test();
            Console.WriteLine(st.X);
            StaticTest st2 = new StaticTest();
            Console.WriteLine(st2.X);
            Console.ReadKey();
        }
    }
}
