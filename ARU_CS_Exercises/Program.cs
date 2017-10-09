// Authoer: matmcc
// Contact: matthew.mcconkey@student.anglia.ac.uk

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARU_CS_Exercises
{
    /*
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
    */

    /*class CountUp
    {
        static void Main(string[] args)
        {
            double counter = 0;
            Console.WriteLine($"Current total is {counter}");
            counter += 2.2;
            Console.WriteLine($"Current total is {counter}");
            counter += 2.5;
            Console.WriteLine($"Current total is {counter}");
            counter += 1.6;
            Console.WriteLine($"Current total is {counter}");
            Console.ReadLine();
        }
    }*/

    /*class WelcomeMsg
    {
        static void Main(string[] args)
        {
            string name, course;
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, welcome to ARU");
            //Console.Read();

            Console.WriteLine("... and which course are you studying?");
            course = Console.ReadLine();

            string[] cs = { "computerscience", "cs", "informationandcommunicationtechnology", "ict" };
            if (cs.Contains(course.Replace(" ", "").ToLower())) // if course in string return course.ToBinary()
            {
                StringBuilder binaryMsg = new StringBuilder();
                course = "Welcome to the " + course + " course";
                foreach (char c in course)
                {
                    binaryMsg.Append(Convert.ToString(c, 2));
                }
                Console.WriteLine(binaryMsg);
            }
            else { Console.WriteLine($"Welcome to the {course} course"); }
        }
    }*/

    class RunBusinessCard
    {
        static void Main(string[] args)
        {
            BusinessCard.Run();
        }
    }
}
