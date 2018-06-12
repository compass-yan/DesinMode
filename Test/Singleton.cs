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
    /// 线程安全+懒加载
    /// </summary>
    public class Singleton
    {
        private static readonly Lazy<Singleton> single=new Lazy<Singleton> (()=>new Singleton ());
        private  Singleton()
        {
           
        }
        public static  Singleton Instance
        {
            get
            {
                return single.Value;
            }
        }
    }
}
