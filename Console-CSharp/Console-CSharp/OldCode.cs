using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CSharp
{
    class OldCode
    {
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

        static void WhileLoop()
        {
            // https://youtu.be/lisiwUZJXqQ?t=893

            int i = 0;

            while (i < 10)
            {
                if (i == 7)
                {
                    i++;
                    continue;
                }
                if (i == 9)
                {
                    break;
                }
                if ((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }
                i++;

            }

            Console.ReadLine();



            // https://youtu.be/lisiwUZJXqQ?t=1021

            string guess;

            do
            {
                Console.WriteLine("Guess a Number: ");
                guess = Console.ReadLine();
            } while (!guess.Equals("15"));  // as long as the user doesn't guess 15 the loop continues


            Console.ReadLine();


            // https://youtu.be/lisiwUZJXqQ?t=1117


            for (int k = 0; k < 10; k++)
            {
                if ((k % 2) > 0)
                {
                    Console.WriteLine(k);
                }
            }

            Console.ReadLine();
        }

        static void LoopingThroughString()
        {
            // https://youtu.be/lisiwUZJXqQ?t=1181
            // a string is a collection of characters
            // looping through the characters in a string

            string randStr = "Here are some random characters";

            foreach (char c in randStr)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }

        static void StringFormatting()
        {
            // https://youtu.be/lisiwUZJXqQ?t=1252
            // String operations

            Console.WriteLine("\' \" \\ two to get one backslash  \b:backspace \t:tab");
            Console.WriteLine("\n: newline");

            string sampString = "A bunch of random words";
            Console.WriteLine("Is empty: " + String.IsNullOrEmpty(sampString));
            Console.WriteLine("Is blank: " + String.IsNullOrWhiteSpace(sampString));
            Console.WriteLine("String Length: " + sampString.Length);

            // https://youtu.be/lisiwUZJXqQ?t=1383

            Console.WriteLine("Index of bunch: " + sampString.IndexOf("bunch"));
            Console.WriteLine("2nd word: " + sampString.Substring(2, 6));

            string sampString2 = "More random words";
            Console.WriteLine("String Equal: " + sampString.Equals(sampString2));
            Console.WriteLine("Starts with \"A bunch\" " + sampString.StartsWith("A bunch"));
            Console.WriteLine("Ends with words " + sampString.EndsWith("words"));

            // https://youtu.be/lisiwUZJXqQ?t=1596

            sampString = sampString.Trim(); // gets rid of white space both sides 
            // TrimEnd get rid of whitespace at the beginning,  TrimStart...
            sampString = sampString.Replace("words", "characters");
            sampString = sampString.Remove(0, 2);

            string[] names = new string[3] { "Matt", "Joe", "Paul" };
            Console.WriteLine("Name List: " + String.Join(", ", names));

            // https://youtu.be/lisiwUZJXqQ?t=1755
            // String formatting

            string formatString = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0)}", 1.56, 15.567, .56, 1000);
            Console.WriteLine(formatString);
            // 0... converts into currency
            // 1... demands specified decimal formatting
            // 2... # is a kind of wildcard
            // 3... 000 separator

            Console.ReadLine();
        }

        static void StringBuilderTest()
        {
            // https://youtu.be/lisiwUZJXqQ?t=1894
            // String builder

            StringBuilder sb = new StringBuilder();

            sb.Append("This is the first sentence. ");
            sb.AppendFormat("My name is {0} and I live in {1} ", "Derek", "Pennsylvania");

            sb.Replace("a", "e");
            sb.Remove(5, 7); // startin from character 5, 7 characters long which includes char 5

            Console.WriteLine(sb.ToString());

            Console.ReadLine();
        }

        static void MultArrayTut()
        {

            // https://youtu.be/lisiwUZJXqQ?t=2025
            // Arrays

            int[] randNumArray;

            int[] randArray = new int[5]; // has 5 ints in it

            int[] randArray2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array Length: " + randArray2.Length);
            Console.WriteLine("Item 0: " + randArray2[0]);

            for (int i = 0; i < randArray2.Length; i++)
            {
                Console.WriteLine("{0}:{1} = ", i, randArray2[i]);
            }

            foreach (int num in randArray2)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Where is 1: " + Array.IndexOf(randArray2, 1));

            string[] names = { "Tom", "Paul", "Sally" };

            string nameStr = string.Join(", ", names);

            string[] nameArray = nameStr.Split(',');

            // https://youtu.be/lisiwUZJXqQ?t=2291

            int[,] multArray = new int[5, 3];

            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            foreach (int num in multArray2)
            {
                Console.WriteLine(num);
            }

            for (int x = 0; x < multArray2.GetLength(0); x++)
            {
                for (int y = 0; y < multArray2.GetLength(1); y++)
                {
                    Console.WriteLine("{0}|{1}:{2}", x, y, multArray2[x, y]);
                }
            }

            Console.ReadLine();
        }

        static void ListTutorial()
        {
            // https://youtu.be/lisiwUZJXqQ?t=2465
            // Lists

            List<int> numList = new List<int>();

            numList.Add(5);
            numList.Add(15);
            numList.Add(25);

            int[] randArray = { 1, 2, 3, 4, 5 };
            numList.AddRange(randArray);

            //numList.Clear();

            List<int> numList2 = new List<int>(randArray);

            List<int> numList3 = new List<int>(new int[] { 1, 2, 3, 4 });

            numList.Insert(1, 10);

            numList.Remove(5); // Remove looks for the name

            numList.RemoveAt(2); // RemoveAt removes ListItem  at index ()

            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }

            Console.WriteLine("4 is in index: " + numList3.IndexOf(4));
            Console.WriteLine("5 in List: " + numList.Contains(5));

            List<string> strList = new List<string>(new string[] { "Tom", "Paul", "Peter", "Mark" });
            Console.WriteLine("Tom in list: " + strList.Contains("tom", StringComparer.OrdinalIgnoreCase));

            strList.Sort();

            for (int i = 0; i < strList.Count; i++)
            {
                Console.WriteLine(strList[i]);
            }

            Console.ReadLine();
        }

        static void TryCatchBlockTutorial()
        {
            // https://youtu.be/lisiwUZJXqQ?t=2711
            // Exceptions

            try
            {
                Console.WriteLine("Divide 10 by ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10/ {0} = {1}", num, (10 / num));
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero!");
                Console.WriteLine(ex.GetType().Name); // names the exception
                Console.WriteLine(ex.Message);        // describes the exception
                throw ex; // throws exception on another catch block to handle
                throw new InvalidOperationException("Operation failed", ex);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
