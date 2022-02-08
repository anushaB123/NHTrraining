using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IShape
    {
        int CalculatePerimeter();
        int CalculateArea();
    }
    class Circle : IShape {

        private int radius;
        public void ReadRadius()
        {
            Console.WriteLine("Enter radius:");
            radius = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return 22*radius*radius/7;
        }

        public int CalculatePerimeter()
        {
            return 2*22*radius/7;
        }
    }
    class Square : IShape
    {

        private int side;
        public void ReadSide()
        {
            Console.WriteLine("Enter side:");
            side= Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return side * side;
        }

        public int CalculatePerimeter()
        {
            return 4 * side;
        }
    }
    class Rectangle : IShape
    {
        private int width;
        private int length;
        public void ReadWidth()
        {
            Console.WriteLine("Enter width:");
            width = Convert.ToInt32(Console.ReadLine());
        }
        public void ReadLength()
        {
            Console.WriteLine("Enter length:");
            length = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return width * length;
        }

        public int CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }
    class Triangle : IShape
    {
        private int side1;
        private int side2;
        private int side3;
        private int area;
        private int semiperimeter;
        
        public void ReadSide1()
        {
            Console.WriteLine("Enter side1:");
            side1 = Convert.ToInt32(Console.ReadLine());
        }
        public void ReadSide2()
        {
            Console.WriteLine("Enter side2:");
            side2 = Convert.ToInt32(Console.ReadLine());
        }
        public void ReadSide3()
        {
            Console.WriteLine("Enter side3:");
            side3= Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            double d;
            d = semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3);

            int Area =(int) Math.Sqrt(d);
            return Area;
        }

        public int CalculatePerimeter()
        {
            return side1 + side2 + side3;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.ReadRadius();
            Console.WriteLine(c.CalculateArea());
            Console.WriteLine(c.CalculatePerimeter());

            Square s = new Square();
            s.ReadSide();
            Console.WriteLine(s.CalculateArea());
            Console.WriteLine(s.CalculatePerimeter());

            Rectangle r = new Rectangle();
            r.ReadWidth();
            r.ReadLength();
            Console.WriteLine(r.CalculateArea());
            Console.WriteLine(c.CalculatePerimeter());

            Triangle t = new Triangle();
            t.ReadSide1();
            t.ReadSide2();
            t.ReadSide3();
            Console.WriteLine(c.CalculateArea());
            Console.WriteLine(c.CalculatePerimeter());
            Console.ReadLine();

        }
        

    }
}
