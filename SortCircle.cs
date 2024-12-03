using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComparableCircle[] circle = new ComparableCircle[3];
            circle[0] = new ComparableCircle(3.6);
            circle[1] = new ComparableCircle();
            circle[2] = new ComparableCircle(2.0,"blue",true);
            Console.WriteLine("Truoc khi Sap Xep: ");
            foreach(Circle c in circle)
            {
                Console.WriteLine(c);
            }
            Array.Sort(circle);
            Console.WriteLine("Sau khi Sap Xep: ");
            foreach (Circle c in circle)
            {
                Console.WriteLine(c);
            }
        }
    }
    public class Circle
    {
        private double radius;
        private string color;
        private bool filled;

        public Circle() { }
        public Circle(double radius)
        {
            this.radius = radius;
            color = "red";
            filled = false;
        }
        public Circle(double radius, string color, bool filled)
        {
            this.radius = radius;
            this.color = color;
            this.filled = filled;
        }
        public double GetRadius()
        {
            return radius;
        }
        public override string ToString()
        {
            return $"Circle:radius={radius}, color: {color}, filled: {filled}";
        }
    }
    public class ComparableCircle:Circle,IComparable<ComparableCircle>
    {
        public ComparableCircle():base() { }
        public ComparableCircle(double radius):base(radius) { }
        public ComparableCircle(double radius, string color, bool filled) : base(radius, color, filled) { }
        public int CompareTo(ComparableCircle other)
        {
            if (this.GetRadius() > other.GetRadius())
            {
                return -1;
            }
            else if(this.GetRadius() < other.GetRadius())
            {
                return 1;
            }
            else { return 0; }
        }

    }
}
