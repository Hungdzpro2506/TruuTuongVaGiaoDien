using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SizeMoi
    {
        static void Main(string[] args)
        {
            ResizeAble[] resizeAbles = new ResizeAble[3];
            resizeAbles[0] = new Circle(3.6);
            resizeAbles[1] = new Rectangle(2.0,3.8);
            resizeAbles[2] = new Square(4.0);
            Random random = new Random();
            foreach (var resizeAble in resizeAbles)
            {
                double PhanTram = random.Next(0,101);
                Console.WriteLine($"truoc khi resize :{resizeAble}");
                resizeAble.Resize(PhanTram);
                Console.WriteLine($"sau khi resize :{resizeAble}");
            }


        }
    }
    public interface ResizeAble
    {
        void Resize(double PhanTram);
    }
    public class Circle : ResizeAble
    {
        private double radius;
        
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double getArea() { return radius * radius * Math.PI; }
        public void Resize(double PhanTram)
        {
            radius *= (1 + PhanTram / 100);
        }
        public override string ToString()
        {
            return $"HinhTron: radius:{radius}, Area={getArea()}";
        }
    }
    public class Rectangle : ResizeAble
    {
        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double getArea()
        {
            return height * width;

        }
        public void Resize(double PhanTram)
        {
            width *= (1+PhanTram/100);
        }
        public override string ToString()
        {
            return $"HCN: Width: {width}, Height: {height}, Area={getArea()}";
        }
    }
    public class Square : ResizeAble
    {
        private double size;

        public Square(double size)
        {
            this.size = size;
        }
        public double getArea() { return size * size; }
        public void Resize(double PhanTram)
        {
            size *= (1 + PhanTram / 100);
        }
        public override string ToString()
        {
            return $"HV: size: {size}, Area={getArea()}";
        }
    }


}
