using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// https://youtu.be/lisiwUZJXqQ?t=4747
// Delegates
// used to pass methods as arguments to other methods

delegate double GetSum(double num1, double num2);


namespace Console_CSharp
{


    class Admiral
    {

        static void Main(string[] args)
        {

            if ("the stuff before FileSystem.OI" == "")
            {
                GetSum sum = delegate (double num1, double num2)
                {
                    return num1 + num2;
                };

                Console.WriteLine("5 + 10 = " + sum(5, 10));

                // https://youtu.be/lisiwUZJXqQ?t=4859
                // lambda expression, used to acts as an anonymous function or expression tree

                Func<int, int, int> getSum = (x, y) => x + y;

                Console.WriteLine("5 + 3 = " + getSum.Invoke(3, 5));

                List<int> numList = new List<int> { 5, 10, 15, 20, 25 };
                List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();

                foreach (int num in oddNums)
                {
                    Console.WriteLine(num + ", ");
                }
            }

            string[] custs = new string[] { "Tom", "Paul", "Greg" };

            using (StreamWriter sw = new StreamWriter("custs.txt"))
            {
                foreach (string cust in custs)
                {
                    sw.WriteLine(cust);
                }
            }

            string custName = "";
            using (StreamReader sr = new StreamReader("custs.txt"))
            {
                while ((custName = sr.ReadLine()) != null)
                {
                    Console.WriteLine(custName);
                }
            }







                Console.ReadLine();

        }
    }


















    public enum Temperature
    {
        Freeze = 1,
        Low = 2,
        Warm = 3,
        Boil = 4
    }
    // https://youtu.be/lisiwUZJXqQ?t=4620
    // Structs = can hold data from many different data types and also have methods inside

    struct Customers
    {
        private string name;
        private double balance;
        private int id;

        public void createCust(string n, double b, int i)
        {
            name = n;
            balance = b;
            id = i;
        }

        public void showCust()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("Id: " + id);
        }

    }


    class Microwave
    {
        static void notsoOldMain(string[] args)
        {

            if (Temperature.Low == Temperature.Freeze)
            {
                // https://youtu.be/lisiwUZJXqQ?t=4523
                // Enum types = unique type with symbolic names and associated values
                // 
                Temperature micTemp = Temperature.Low;

                switch (micTemp)
                {
                    case Temperature.Freeze:
                        Console.WriteLine("Temp on Freezing");
                        break;

                    case Temperature.Low:
                        Console.WriteLine("Temp on Low");
                        break;
                    case Temperature.Warm:
                        Console.WriteLine("Temp on Warm");
                        break;
                    case Temperature.Boil:
                        Console.WriteLine("Temp on Boil");
                        break;

                }
            }

            // https://youtu.be/lisiwUZJXqQ?t=4704
            // using Struct

            Customers bob = new Customers();
            bob.createCust("Bob", 15.50, 12345);

            bob.showCust();



            Console.ReadLine();

        }
    }

}
