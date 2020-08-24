using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Constructor
{
    class Rectangle
    {
        double length;
        double breadth;
        public Rectangle()
        {
            Console.WriteLine("Default Constructor of Base Class");
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Breadth
        {
            get { return breadth; }
            set { breadth = value; }
        }
        public void DisplayDimen()
        {
            Console.WriteLine("Length :" + Length + " " + "Breadth :" + Breadth);
        }
    }
    //Derived Class
    class AreaofRectangle : Rectangle
    {
        string shape;
        public string Shape
        {
            get { return shape; }
        }
        public AreaofRectangle(string c, double l, double b)
        {
            shape = c;
            Length = l;
            Breadth = b;
        }
        public double Area()
        {
            return (Length * Breadth);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AreaofRectangle obj = new AreaofRectangle("Rectangle", 12.0, 9.0);
            obj.DisplayDimen();
            Console.WriteLine("Shape :" + obj.Shape);
            double area = obj.Area();
            Console.WriteLine("Area :" + area+"cm2");
            Console.ReadKey();
        }
    }
}
