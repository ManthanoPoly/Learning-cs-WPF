using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobTaborTutorials
{
    class StringsAndClasses
    {

        static void StringsAndClassesToConsole()
        {
            /*
            string myString1 = @"Go to your C:\ drive"; // @ tells cs not to treat / as escape characters
            Console.WriteLine(myString1);

            DateTime myDT1 = DateTime.Now;
            Console.WriteLine(myDT1.ToString());
            Console.WriteLine(myDT1.ToShortDateString());
            Console.WriteLine(myDT1.ToShortTimeString());
            Console.WriteLine(myDT1.ToLongDateString());
            Console.WriteLine(myDT1.ToLongTimeString());

            Console.WriteLine(myDT1.AddDays(3).ToLongDateString());
            Console.WriteLine(myDT1.AddHours(3).ToLongTimeString());

            Console.WriteLine(myDT1.AddDays(-3).ToLongDateString());
            Console.WriteLine(myDT1.Month);

            DateTime myBirthday = new DateTime(1969, 12, 7);
            Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myDoB = DateTime.Parse("12/7/1969");
            TimeSpan myAge = DateTime.Now.Subtract(myDoB);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
            */

            // More About Classes and Methods
            // https://www.youtube.com/watch?v=RIbR8Fi6zq0&index=16&list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN

            // deterministic finalisation >> https://youtu.be/RIbR8Fi6zq0?list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN&t=1016

            // if you use keyword static in a method you don't need to create an instance of the class to use the method. A static class would contain only static methods and doesn't need to repeat the keyword
            Car myCar = new Car();
            Car.MyMethod();


            Console.ReadLine();
        }

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }


        // https://youtu.be/Y9JWrMjx0_w?list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN&t=350
        // use 'prop' [tab] [tab] to get VS provide you with a template
        // https://youtu.be/Y9JWrMjx0_w?list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN&t=863
        // use 'propfull' [tab] [tab] to get the long version with private variable

        // https://youtu.be/RIbR8Fi6zq0?list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN&t=1183
        // this. keyword refers to this instance of the class and is optional
        // 

        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
            // Console.WriteLine(Make); //>> doesn't work as a static can't depend on a given state of a class but Make is only available after instantiation
        }

    }
}

