using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CSharp
{
    class AnimalClass
    {
    }

    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Constructor

        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
        }

        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++; // cool; this way you can count all the different object you have created from this class
        }

        static int numOfAnimals = 0;
        public static int getNumOfAnimals() // static method can only have access to other static attr.
        {
            return numOfAnimals;
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}.", name, height, weight, sound);

        }

        // https://youtu.be/lisiwUZJXqQ?t=3440
        // method overloading

        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }


        static void oldmain(string[] args)
        {

            if ("classes" == "cool")
            {
                // https://youtu.be/lisiwUZJXqQ?t=2890
                // Classes and Objects

                Animal spot = new Animal(15, 10, "Spot", "Woof");

                Console.WriteLine("{0} says {1}", spot.name, spot.sound);
                Console.WriteLine($"Number of Animals: {Animal.getNumOfAnimals()}");

                Console.WriteLine(spot.toString());

                Console.WriteLine(spot.getSum(1, 2));
                Console.WriteLine(spot.getSum(1.353, 2.54643));
                Console.WriteLine(spot.getSum(num2: 1.353, num1: 2.54643));

                // another way to create an object 
                Animal grover = new Animal  // class initialiser
                {
                    name = "Grover",
                    height = 16,
                    weight = 18,
                    sound = "Grrrr"
                };  // that ; seems off placed but it's correct syntax

                Dog spike = new Dog();
                Console.WriteLine(spike.toString());

                spike = new Dog(20, 15, "Spike", "Grrr", "Chicken");

                Console.WriteLine(spike.toString());
                Console.ReadLine();
            }


            if ("abstract classes" == "are complicated")
            {
                // https://youtu.be/lisiwUZJXqQ?t=4180
                // Using abstract and interfact etc. 

                Shape rect = new Rectangle(5, 5);
                Shape tri = new Triangle(5, 5);   // this is polymorphism

                Console.WriteLine("Rect Area: " + rect.area());
                Console.WriteLine("Tri Area: " + tri.area());

                Rectangle combRect = new Rectangle(5, 5) + new Rectangle(5, 5);
                Console.WriteLine("CombRect Area: " + combRect.area());
                Console.ReadLine();
            }

            // https://youtu.be/lisiwUZJXqQ?t=4404
            // using generic class

            KeyValue<string, string> superman = new KeyValue<string, string>("", "");

            superman.key = "Superman";
            superman.value = "Clark Kent";

            KeyValue<int, string> samsungTV = new KeyValue<int, string>(0, "");

            samsungTV.key = 12345;
            samsungTV.value = "a 50\" Samsung TV";

            superman.showData();
            samsungTV.showData();

            Console.ReadLine();
        }



    }

    // new sub class and : means Dog inherits all the attributes of Animal
    class Dog : Animal
    {
        public string favFood { get; set; }

        public Dog() : base() // means that we are getting all the other attributes from the super class
        {
            this.favFood = "No Favourite Food.";
        }

        public Dog(double height, double weight, string name, string sound, string favFood) : base(height, weight, name, sound) // this would directly initialise all the attributes common to both leaving only the added one for favFood to be done
        {
            this.favFood = favFood;
        }

        new public string toString() // new in front means overwriting the method from Animal
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3} and eats {4}", name, height, weight, sound, favFood);
        }


    }

    // https://youtu.be/lisiwUZJXqQ?t=3810
    // abstract class
    // you can only inherit one abstract class per class
    // but with an interface you can inherit multiple interfaces
    // can't create/instantiate object from abstract class

    abstract class Shape
    {
        public abstract double area();

        public void sayHi()
        {
            Console.WriteLine("Hello");
        } // abstract classes can contain non-abstract methods but interfaces can not
    }

    public interface ShapeItem
    { // every single method in an interface is an abstract method
        double area();
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        // Constructor
        public Rectangle(double num1, double num2)
        {
            length = num1;
            width = num2;
        }

        // overwriting the area() method from abstract class Shape
        public override double area()
        {
            return length * width;
        }

        public static Rectangle operator +(Rectangle rect1, Rectangle rect2)
        {
            double rectLength = rect1.length + rect2.length;
            double rectWidth = rect1.width + rect2.width;
            return new Rectangle(rectLength, rectWidth);
        }
    }

    class Triangle : Shape
    {
        private double theBase;
        private double height;

        public Triangle(double num1, double num2)
        {
            theBase = num1;
            height = num2;
        }

        public override double area()
        {
            return 0.5 * (theBase * height);
        }
    }

    // https://youtu.be/lisiwUZJXqQ?t=4305
    // Generics and generic class

    class KeyValue<TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }

        public KeyValue(TKey k, TValue v)
        {
            key = k;
            value = v;
        }

        public void showData()
        {
            Console.WriteLine("{0} is {1} ", this.key, this.value);
        }

    }

}
