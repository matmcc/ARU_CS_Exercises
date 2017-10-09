using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARU_CS_Exercises
{
    class RetirementPlanner
    {
        private double _age, _oldAge;
        private double? _diff;
        
        public RetirementPlanner(double age = 0, double oldAge = 65)
        {
            _age = age;
            _oldAge = oldAge;
            _diff = null;

            Console.WriteLine("Please enter your age in years");
            age = double.Parse(Console.ReadLine());
            _diff = oldAge - age;
            Console.WriteLine($"In {_diff} years you will be 65. You *might* be allowed to retire");
            Console.Read();
        }
        
    }
}
