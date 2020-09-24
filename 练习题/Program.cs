using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习题
{
    abstract class Shape
    {
        public double x, y;
        public Shape(double x, double y)
        {
            this.x = x;this.y = y;
        }
        public abstract double getArea();//获取面积
    }
    class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height) { }
        public override double getArea(){return x * y;}
    }
    class Circle : Shape
    {
        public Circle(double radius) : base(radius, 0) { }
        public override double getArea() {return Math.PI * x * x; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //产生随机形状
            Shape[] shapes = new Shape[5]; //分配五个数组
            Random rnd = new Random();
            for (int i = 0; i < shapes.Length; i++)
            {
                int type = rnd.Next(0, 2);//随机形状
                int x = rnd.Next(1, 101);//设定X的值
                int y = rnd.Next(1, 101);//设定Y的值
                switch (type)
                {
                    case 0:shapes[i] = new Rectangle(x, y);break;
                    case 1: shapes[i] = new Circle(x);break;
                    default:
                        break;
                }
            }
            //求和
            double area_sum = 0;//各面积之和
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Rectangle)//判断是否是矩形，里氏转换
                {
                    Console.WriteLine("第{0}号形状:矩形（{1:0.00},{2:0.00}）,面积={3:0.00}", i, shapes[i].x, shapes[i].y, shapes[i].getArea());
                }
                else
                {
                    Console.WriteLine("第{0}号形状:圆形（{1:0.00}）,面积={2:0.00}", i, shapes[i].x,  shapes[i].getArea());
                }
                area_sum = area_sum + shapes[i].getArea();//获取面积
            }
            Console.WriteLine("面积之和：{0:0.00}\n", area_sum);
            Console.ReadKey();

        }
    }
}
