using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARU_CS_Exercises
{
    class BusinessCard
    {
        protected string name, num, employer;
        protected int width, height, PAD_SIZE;


        private void BusinessCardInput()
        {
            // Get name, number, business
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Can I have your number?");
            num = Console.ReadLine();
            Console.WriteLine("Who is your employer?");
            employer = Console.ReadLine();

            string[] stuff = { name, num, employer };

            // width = Max(Length(name, number, business)) + whitespace_padding
            int c = 0;
            PAD_SIZE = 2;
            foreach (string thing in stuff)
            {
                if (thing.Length > c)
                { c = thing.Length; }
            }
            width = c + PAD_SIZE;

            // height = array.length(of_above_things) + padding
            height = stuff.Length + PAD_SIZE;

            // if topline or bottomline print horizontal line of border char
            // else print (first char = border char) + (padded input) + (last char = border char)
            
        }

        static void Main(string[] args)
        {
            var bc = new BusinessCard();
            bc.BusinessCardInput();
            Console.WriteLine($"{bc.name}, {bc.num}, {bc.employer}, {bc.width}, {bc.height}");
        }
    }
}
