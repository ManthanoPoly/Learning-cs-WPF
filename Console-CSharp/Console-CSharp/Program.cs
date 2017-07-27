using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://youtu.be/lisiwUZJXqQ?t=893


            Console.ReadLine();
        }


        static void oldcode()
        {
            /*
            https://youtu.be/lisiwUZJXqQ?t=107
            variable 'name' and combining string with variable
            datatype is in front of the variable, not after as in vb.NET
            */
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);


            // https://youtu.be/lisiwUZJXqQ?t=191
            bool canVote = true;

            char grade = 'A'; // single 16bit Unicode character

            // Integer with a max number of 2,147,483,647 
            // maxValue puts this number into the variable
            int maxInt = int.MaxValue;

            // Long with a max number of 9,223,372,036,854,775,807
            long maxLong = long.MaxValue;

            // Decimal has a maximum value of 79,228,162,514,264,337,593,543,950,335
            // If you need somthing bigger look up BigInteger
            decimal maxDec = decimal.MaxValue;

            // A float is a 32bit number with a maxValue of 3.402823E+38 with 7 decimals of precision
            float maxFloat = float.MaxValue;

            // A double is a 32bit number with a maxValue of 1.797693134E+308 with 15 decimals of precision
            double maxDouble = double.MaxValue;

            Console.WriteLine("Max Int: " + maxInt);

            var anotherName = "Tom"; // var automatically assigns a fitting datatype
            // anotherName = 2; but this would cause problems because var becomes string and you are putting an int into it

            Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());
            Console.ReadLine();



            // https://youtu.be/lisiwUZJXqQ?t=393
            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3)); // = 2.2 meaning that 5.2 / 3 leaves a rest of 2.2

            int i = 0;

            Console.WriteLine("i++ = " + (i++)); // increments after it was added to the string
            Console.WriteLine("++i = " + (++i)); // increments before it was added to the string
            Console.WriteLine("i-- = " + (i--));
            Console.WriteLine("--i = " + (--i));

            Console.WriteLine("i += 3 >> " + (i += 3)); // i = i + 3
            Console.WriteLine("i -= 2 >> " + (i -= 2));
            Console.WriteLine("i *= 2 >> " + (i *= 2));
            Console.WriteLine("i /= 2 >> " + (i /= 2));
            Console.WriteLine("i %= 2 >> " + (i %= 2));

            Console.ReadLine();


            // https://youtu.be/lisiwUZJXqQ?t=477

            double pi = 3.1415;
            int intPi = (int)pi;

            // Math Functions built in
            // Acos, Asin, Atan, Atan2, Cos, Cosh, Exp, Log, Sin, Sinh, Tan, Tanh

            double number1 = 10.5;
            double number2 = 15;

            Console.WriteLine("Math.Abs(number1) " + (Math.Abs(number1))); // absolute value
            Console.WriteLine("Math.Ceiling(number1) " + (Math.Ceiling(number1))); // round up value
            Console.WriteLine("Math.Floor(number1) " + (Math.Floor(number1))); // round down value
            Console.WriteLine("Math.Max(number1, number2) " + (Math.Max(number1, number2)));
            Console.WriteLine("Math.Min(number1, number2) " + (Math.Min(number1, number2)));
            Console.WriteLine("Math.Pow(number1, 2) " + (Math.Pow(number1, 2))); // Power
            Console.WriteLine("Math.Round(number1) " + (Math.Round(number1)));
            Console.WriteLine("Math.Sqrt(number1) " + (Math.Sqrt(number1))); // square root

            Random rand = new Random();
            Console.WriteLine("Random Number between 1 and 10: " + (rand.Next(1, 11)));

            Console.ReadLine();




            // https://youtu.be/lisiwUZJXqQ?t=610
            // Relational Operators: >  <  >=   <=   ==  !=   last two: equal to and not equal to
            // Logical Operators: && AND    || OR   ^ Exlusive OR     ! NOT 

            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("Go to high school");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("! true = " + (!true));

            bool canDrive = age >= 16 ? true : false; //if age >=16 then set canDrive = true
            int canDrive2 = age >= 16 ? 1 : 3;


            // https://youtu.be/lisiwUZJXqQ?t=799
            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");
                    goto Cute;
                default:
                    Console.WriteLine("Child");
                    break;   // break; always needed unless you have nothing under a case or goto

            }
        Cute:
            Console.WriteLine("Toddlers are Cute");

            Console.ReadLine();
        }
    }
}
