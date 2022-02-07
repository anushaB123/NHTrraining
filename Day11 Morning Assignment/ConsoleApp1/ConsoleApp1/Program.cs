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
        int radius;
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
    class Suare : IShape
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
        public double base;
        private int side;
        private double height;
        public void CalculateBase()
        {
            Console.WriteLine("Enter base:");
            base= Convert.ToDouble(Console.ReadLine());
        }
        public void CalculateHeight()
        {
            Console.WriteLine("Enter height:");
            height = Convert.ToDouble(Console.ReadLine());
        }
        public void CalculateSide()
        {
            Console.WriteLine("Enter side:");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return (height * base) / 2;
        }

        public int CalculatePerimeter()
        {
            return side * base * side;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
