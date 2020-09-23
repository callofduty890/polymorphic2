using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_23_多态2
{
    class Parent //基类
    {
        public void MethodA()
        {
            Console.WriteLine("调用MethodA()");
        }
    }

    class Child : Parent//派生类
    {
        public void MethodB()
        {
            Console.WriteLine("调用MethodB()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent oparent = new Parent();
            oparent.MethodA();//OK  调用Parent的方法
            //Child ochild = (Child)oparent;//错误：子类装父类
            //ochild.MethodB();

            Child oChild = new Child();
            oChild.MethodA();    //OK 调用基类Parent 成员方法
            oChild.MethodB();    //OK 调用派生类的方法

            Parent oparent1 = oChild;//父类装子类的对象
            oparent.MethodA(); //OK 调用派生类的方法
            //oparent.MethodB(); //编译错误！，基类不包含方法

            Child oChild2 = (Child)oparent1;
            oChild2.MethodA();  //OK 调用基类Parent 成员方法
            oChild2.MethodB();  //OK 调用派生类的方法

            Console.ReadKey();

        }
    }
}
