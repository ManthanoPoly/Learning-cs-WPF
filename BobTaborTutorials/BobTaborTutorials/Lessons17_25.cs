using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobTaborTutorials
{ 
    public class Lessons17
    {

        private static string k = "";



        public static void printUnderstandingScope()
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);
            }


            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for: " + k);

            HelperMethod();

            // https://youtu.be/0QgtXLQyufI?list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN&t=560
            // you should never need to know how a class works.
            // all the internal workings should be encapsulated behind interfaces which are
            // your public methods and public properties

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod():"+ k);
        }
    }
}
