using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_里氏转换
{
    class Friut
    {
        
    }

    class Apple : Friut
    {
        public void EatA()
        {
            Console.WriteLine("我是苹果的吃法");
        }
    }

    class Banana : Friut
    {
        public void EatB()
        {
            Console.WriteLine("我是香蕉的吃法");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //[1] 子类可以赋值给父类
            Friut fr = new Apple();

            //[2] 如果父类中装的是子类的对象，那么可以将这个父类转换为子类的对象
            Apple ap = (Apple)fr;
            ap.EatA();
            Console.WriteLine("======================");
            //[3] is 的用法
            Friut fr2 = new Banana();
            if (fr2 is Apple)
            {
                Console.WriteLine("转换成功");
                ap = (Apple)fr;
                ap.EatA();
            }
            else
            {
                Console.WriteLine("转换失败！");
            }
            Console.WriteLine("======================");
            Friut fr3 = new Apple();
            Banana ba = fr3 as Banana;
            if (ba != null)
            {
                Console.WriteLine("转换成功");
                ba.EatB();
            }
            else
            {
                Console.WriteLine("转换失败!");
            }
            Console.ReadKey();
        }
    }
}
