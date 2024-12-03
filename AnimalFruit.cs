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
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
                if (animal is Chicken)
                {
                    Edible edible = (Chicken)animal;
                    Console.WriteLine(edible.HowToEat());
                }
            }
            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Apple();
            fruits[1] = new Orange();
            foreach(Fruit fruit in fruits)
            {
                Console.WriteLine(fruit.HowToEat());
            }
        }
    }
    public abstract class Animal
    {
        public abstract string MakeSound();
    }
    public class Tiger : Animal
    {
        public override string MakeSound()
        {
            return "TIGER: GRRRRRRRR!!!";
        }
    }
    public class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "CHICKEN: Cuc Tac ! Cuc Tac!";
        }
        public string HowToEat()
        {
            return "Co the chien ran!";
        }
    }
    public interface Edible
    {
        string HowToEat();
    }
    public abstract class Fruit : Edible
    {
        public abstract string HowToEat();
    }
    public class Apple : Fruit
    {
        public override string HowToEat()
        {
            return "TAO: Co the Bo thanh mieng! ";
        }
    }
    public class Orange: Fruit
    {
        public override string HowToEat()
        {
            return "CAM: Co the Ep nuoc! ";
        }
    }

}
