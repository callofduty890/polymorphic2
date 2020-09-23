using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_继承实现多态2
{
    interface ICommon { void f(); }//声明接口，定义无返回值函数
    abstract class Base { public abstract void g(); }//抽象类
    class Derived1 :  Base,ICommon
    {
        //实现从接口继承的方法
        public void f() { Console.WriteLine("Derived1.f()"); }
        //重写从基类继承的方法
        public override void g(){Console.WriteLine("Derived1.g()");}
        //重新定义新方法h
        public void h() { Console.WriteLine("Derived1.h()"); }
    }
    class Derived2 : ICommon
    {
        //实现从接口继承的方法
        public void f() { Console.WriteLine("Derived2.f()"); }
        //重新定义新方法h
        public void h() { Console.WriteLine("Derived2.h()"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //可以调用Derived1类及其继承的所有方法
            Derived1 d1 = new Derived1();d1.f();d1.g();d1.h();
            Console.WriteLine("=======================");
            //Derived1 已经实现接口故可以调用接口成员函数
            ICommon c1 = new Derived1();c1.f();
            //访问Derived1 中重写的方法
            Base b1 = new Derived1();b1.g();
            Console.WriteLine("=======================");
            //b1.f();  //编译错误！，Base中没有声明方法
            object o1 = new Derived1();
            Console.WriteLine(o1.GetType());
            //o1.f();//编译错误。object没有包含f()的方法
            //Base b2 = new Derived2();//编译错误，没有相同的实现

            Console.ReadKey();
        }
    }
}
