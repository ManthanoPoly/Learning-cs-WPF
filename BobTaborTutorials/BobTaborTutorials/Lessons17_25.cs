using MyBobTaborCode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Timers;

namespace BobTaborTutorials
{ 

    public class Lesson17
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


    public class Lesson18
    {
        public static void printUnderstanding_NameSpacesDotNET()
        {
            // https://youtu.be/pOq-gZcIKOo?list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN&t=755

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            File.WriteAllText(@"Lesson18.html", reply);

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }

    public class Lesson19
    {
        // https://youtu.be/FUGHOY3ApeU?list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN&t=15
        // 19 Creating And Adding References To Assemblies

        public static void printLesson()
        {
            // took me some time getting this working with the .dll
            // It's important to start a new project and not click on this project, add, new item, class. That's not the same as a proper Class Libary (.NET Framework)
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebpage("http://msdn.microsoft.com");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }

    public class Lesson20
    {
        public static void printLesson()
        {
            // https://youtu.be/u0ApDUs4wO8?list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN&t=38
            // Collections are arrays on steroids which support Linq
            // lists and dictionaries are collections
            /*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "A2";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";

            
            // ArrayLists are dynamically sized,
            // cool features sorting, remove items
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);    // this will throw an exception
            myArrayList.Remove(b1);

           
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            // List<T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */


            /*
            // Dictionary<TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["A2"].Make);
            */

            // Object initialiser
            // No need for a constructor
            //Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3" };
            //Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4" };

            // Collection initialiser
            List<Car> myList = new List<Car>() {
                new Car { Make = "Oldsmobile", Model = "Cutlas Supreme", VIN = "E5"},
                new Car { Make = "Nissan", Model = "Altima", VIN = "F6"}
            };

            Console.ReadLine();
        }

        class Car
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }



    }

    public class Lesson21
    {
        public static void printLesson()
        {
            // https://youtu.be/A3qzCoK9_6w?list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN&t=8
            // Working with Linq

            List<Car> myCars = new List<Car>() {
                new Car() {VIN="A1", Make="BMW", Model="550i", StickerPrice=55000, Year=2009},
                new Car() {VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() {VIN="C3", Make="BMW", Model="745li", StickerPrice=75000, Year=2008},
                new Car() {VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() {VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            // LINQ query
            var bmws1 = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;

            // sorting
            var orderedCars1 = from car in myCars
                              orderby car.Year descending
                              select car;

            // LINQ method
            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            // expression in () is lambda expression, p is an instance of the collection
            // var keyword is nothing like vb or java, 'var' lets the compiler figure out what the datatype is
            var orderedCars2 = myCars.OrderByDescending(p => p.Year);

            foreach (var car in bmws)
            {
                //Console.WriteLine("{0} {1} \n", car.Model, car.VIN);
            }

            foreach (var car in orderedCars2)
            {
                //Console.WriteLine("{0} {1} \n", car.Year, car.Model, car.VIN);
            }

            var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN + "\n");

            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007));  // are they all greater than 2012 > false, 2007 > true


            myCars.ForEach(p => p.StickerPrice -= 3000);
            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            Console.WriteLine("myCars.Exists: " + myCars.Exists(p => p.Model == "745li"));
            Console.WriteLine("myCars.Sum: " + myCars.Sum(p => p.StickerPrice) + " \n");




            Console.WriteLine(myCars.GetType());
            var orderedCars3 = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars3.GetType());
            Console.WriteLine(bmws.GetType());

            var newCars = from car in myCars
                        where car.Make == "BMW"
                        && car.Year == 2010
                        select new { car.Make, car.Model }; // new produces a collection of anonymous types
            Console.WriteLine(newCars.GetType());


            Console.ReadLine();
        }

        class Car
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public double StickerPrice { get; set; }
        }
    }

    public class Lesson22
    {
        public static void printLesson()
        {
            // https://youtu.be/W9rK_rVqTfU?list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN&t=1
            // Enums and Switch

            List<Todo> todos = new List<Todo>()
            {
                new Todo { Description = "Task 1", EstimatedHours = 6, Status = Status.Completed},
                new Todo { Description = "Task 2", EstimatedHours = 2, Status = Status.InProgress},
                new Todo { Description = "Task 3", EstimatedHours = 8, Status = Status.NotStarted},
                new Todo { Description = "Task 4", EstimatedHours = 12, Status = Status.Deleted},
                new Todo { Description = "Task 5", EstimatedHours = 6, Status = Status.InProgress},
                new Todo { Description = "Task 6", EstimatedHours = 2, Status = Status.NotStarted},
                new Todo { Description = "Task 7", EstimatedHours = 14, Status = Status.NotStarted},
                new Todo { Description = "Task 8", EstimatedHours = 8, Status = Status.Completed},
                new Todo { Description = "Task 9", EstimatedHours = 8, Status = Status.InProgress},
                new Todo { Description = "Task 10", EstimatedHours = 8, Status = Status.Completed},
                new Todo { Description = "Task 11", EstimatedHours = 4, Status = Status.NotStarted},
                new Todo { Description = "Task 12", EstimatedHours = 10, Status = Status.Completed},
                new Todo { Description = "Task 13", EstimatedHours = 12, Status = Status.Deleted},
                new Todo { Description = "Task 14", EstimatedHours = 6, Status = Status.Completed}
            };

            // Console.ForegroundColor = ConsoleColor.Black;

            PrintAssessment(todos);
            Console.ReadLine();
        }

        private static void PrintAssessment(List<Todo> todos)
        {
            foreach (var todo in todos)
            { // cool shortcut macro to fill out entire switch syntax https://youtu.be/W9rK_rVqTfU?list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN&t=570 but you have to start that macro with switch, not todo.status...
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Description);
            };
        }

        class Todo
        {
            public string Description { get; set; }
            public int EstimatedHours { get; set; }
            public Status Status { get; set; }

        }

        enum Status
        {
            NotStarted, 
            InProgress, 
            OnHold,
            Completed,
            Deleted
        }

    }

    public class Lesson23
    {
        public static void printLesson()
        {
            // https://youtu.be/iqgB0FOau4k?list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN&t=4
            // gracefully handling exceptions

            // uncomment line below to create the file below in the folder that will be used further still. I didn't want to  use C:\
            //File.WriteAllText("Example.txt", "All you need in this life is ignorance and confidence, and then success is sure.\n- Mark Twain");

            try
            {
                string content = File.ReadAllText("Exampl.txt");
                Console.WriteLine(content);
            }
            // start with the most specific case and work yourself forward to the most general case which is always Exception ex
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is named correctly.");

            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the directory exists.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Code to finalize
                // setting objects to null
                // closing database connections
                Console.WriteLine("Closing the application.");
            }


            Console.ReadLine();
        }
    }

    public class Lesson24
    {
        public static void printLesson()
        {
            // https://youtu.be/3SoZsCxVzPk?list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN&t=3
            // Events and Event driven Programming
            // Events help dev to respond to events in life cycle of application
            // so far we have only seen application start up

            Timer myTimer = new Timer(1000);

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1; ;

            myTimer.Start();

            Console.WriteLine("Press enter to remove the red event.");
            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed1;

            Console.ReadLine();

            // https://youtu.be/3SoZsCxVzPk?list=PLm-PcOa0HEDbnEdssI8lFgeY9NjI9u6RN&t=702
            // create a WPF application
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
