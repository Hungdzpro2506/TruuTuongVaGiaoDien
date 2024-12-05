using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ToMau
    {
        static void Main(string[] args)
        {
            object[] shapes = new object[3];
            shapes[0] = new Square(2.0);
            shapes[1] = new Circle(3.5);
            shapes[2] = new Square(4.0);
            foreach(var shape in shapes)
            {
                if (shape is IColorable colorableShape)
                {
                    Console.WriteLine(colorableShape.ToString());
                    colorableShape.HowToColor();
                }
                else if (shape is Circle circleShape) { 
                Console.WriteLine(circleShape.ToString());
                }
            }
        }
    }
    public interface IColorable
    {
        void HowToColor();
    }
    public class Square : IColorable
    {
        private double size;
        public Square(double size)
        {
            this.size = size;
        }
        public double GetArea()
        {
            return size * size;
        }
        public void HowToColor()
        {
            Console.WriteLine( "Color all four sides");
        }
        public override string ToString() {
            return $"HV:    Size={size}, Area={GetArea()}";
        }
        
    }
    public class Circle
    {
        private double radius;
        public Circle(double radius) { }
        public double GetArea() { return radius * radius * Math.PI; }
        public override string ToString()
        {
            return $"HINHTRON: radius={radius}, Area={GetArea()}";
        }
    }
}
