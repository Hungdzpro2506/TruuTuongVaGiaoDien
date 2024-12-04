using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SoSanhHinhTron
    {
        static void Main(string[] args)
        {
            Circle[] circle = new Circle[3];
            circle[0] = new Circle(3.6);
            circle[1] = new Circle();
            circle[2] = new Circle(3.8);
            circle[3] = new Circle(2.0, "blue", true);
            Console.WriteLine("Truoc khi Sap Xep: ");
            foreach (Circle c in circle)
            {
                Console.WriteLine(c);
            }
            
            IComparer<Circle> circleComparator = new CircleComparator();
            Array.Sort(circle, circleComparator);
            foreach (Circle c in circle)
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
    public class CircleComparator : IComparer<Circle>
    {
       public int Compare(Circle c1, Circle c2)
        {
            if(c1.GetRadius() > c2.GetRadius())
            {
                return 1;
            }
            else if (c1.GetRadius() < c2.GetRadius())
            {
                return -1;
            }
            else { return 0;}
        }

    }
}
