using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// 单例模式
    /// 参考网址：https://www.jianshu.com/p/3ae1bd656c1f
    /// </summary>
    public class Singleton
    {
        private static Singleton single;
        private  Singleton()
        {
            single = new Singleton();
        }
    }
}
