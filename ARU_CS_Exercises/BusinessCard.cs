using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARU_CS_Exercises
{
    class BusinessCard
    {
        static void BusinessCardWriter()
        {
            // Get name, number, business
            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine();
            Console.WriteLine("Can I have your number?");
            var num = Console.ReadLine();
            Console.WriteLine("Who is your employer?");
            var employer = Console.ReadLine();

            object[] stuff = { name, num, employer };

            // width = Max(Length(name, number, business)) + whitespace_padding
            int c = 0;
            int PADDING_SIZE = 2;
            foreach (var thing in stuff)
            {
                if (thing.ToString().Length > c)
                { c = thing.ToString().Length; }
            }
            int width = c + PADDING_SIZE;

            // height = array.length(of_above_things) + padding
            int height = stuff.Length + PADDING_SIZE;

            // if topline or bottomline print horizontal line of border char
            // else print (first char = border char) + (padded input) + (last char = border char)

        }

        static void Main(string[] args)
        {
            BusinessCard.BusinessCardWriter();
        }
    }
}
