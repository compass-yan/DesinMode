using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class ReadonlyTest
    {
        public readonly int y = 10;
        public static int k = 50;
        public static readonly int m = 99;
        public ReadonlyTest(int vy, int vk)//int vm
        {
            y = vy;
            k = vk;
            // m = vm;//  无法对静态只读字段赋值(静态构造函数或变量初始值中除外)  
        }
        static ReadonlyTest()
        {
            m = 111;
        }
        public  ReadonlyTest(int vy)
        {
            y = vy;
        }
    }
}
