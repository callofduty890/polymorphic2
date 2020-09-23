using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_方法的重载
{
    class P0  //基类
    {
        public void MethodA() { Console.WriteLine("调用类P0的方法MethodA() .");}
    }

    class C0 : P0
    {
        //重载方法：重载从基类继承的MethodA(string A)
        public void MethodA(string str) 
        {
            Console.WriteLine("调用类C0的方法MethodA(string str)：" + str);
        }
        public void MethodB(string str1)//重载方法：MethodB
        {
            Console.WriteLine("调用类C0的方法 MethodB(string str1)：" + str1);
        }
        public void MethodB(int str1)//重载方法：MethodB
        {
            Console.WriteLine("调用类C0的方法 MethodB(int str1)：" + str1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            C0 obj0 = new C0();
            obj0.MethodA("abc");
            obj0.MethodB("xyz");
            obj0.MethodB(123);

            Console.ReadKey();
        }
    }
}
