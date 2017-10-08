// Authoer: matmcc
// Contact: matthew.mcconkey@student.anglia.ac.uk

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
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

    class CountUp
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.WriteLine($"Current total is {counter}");
            counter += 2;
            Console.WriteLine($"Current total is {counter}");
            counter += 1;
            Console.WriteLine($"Current total is {counter}");
            counter++;
            Console.WriteLine($"Current total is {counter}");
            Console.ReadLine();
        }
    }
}
