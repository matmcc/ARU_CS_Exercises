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
        // TODO: Constructor???

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
            height = stuff.Length + (2*PAD_SIZE);            
        }

        private void BusinessCardWriter()
        {
            for (int i = 0; i < height+1; i++)
            {
                if (i == 0 || i == (height))    // if topline or bottomline print horizontal line of border char
                {
                    Console.WriteLine(new String('+', width + PAD_SIZE));
                }
                else if (i < PAD_SIZE || i > height - PAD_SIZE)   // else print (first char = border char) + (padded input) + (last char = border char)
                {
                    Console.Write("+");
                    Console.Write("+\n".PadLeft(width + PAD_SIZE, ' '));
                }
                else if (i == PAD_SIZE)
                {
                    Console.WriteLine("+" + name.PadLeft(name.Length + (width - name.Length)/2, ' ').PadRight(width, ' ') + "+");
                }
                else if (i == PAD_SIZE + 1)
                {
                    Console.WriteLine("+" + num.PadLeft(num.Length + (width - num.Length) / 2, ' ').PadRight(width, ' ') + "+");
                }
                else if (i == PAD_SIZE + 2)
                {
                    Console.WriteLine("+" + employer.PadLeft(employer.Length + (width - employer.Length) / 2, ' ').PadRight(width, ' ') + "+");
                }
            }
        }

        static void Main(string[] args)
        {
            var bc = new BusinessCard();
            bc.BusinessCardInput();
            bc.BusinessCardWriter();
            // Console.WriteLine($"{bc.name}, {bc.num}, {bc.employer}, {bc.width}, {bc.height}");
        }
    }
}
