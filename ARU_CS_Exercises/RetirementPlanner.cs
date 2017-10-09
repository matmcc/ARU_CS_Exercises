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
        private int? _months;

        public RetirementPlanner(double age = 0, double oldAge = 65)
        {
            _age = age;
            _oldAge = oldAge;
            _diff = null;
            _months = null;

            Console.WriteLine("Please enter your age in years");
            age = double.Parse(Console.ReadLine());
            _diff = oldAge - age;
            if (_diff - (int)_diff != 0)    // are doubles going to break this?
                _months = (int)((_diff - (int)_diff) * 12);

            if (_diff <= 0)
                Console.WriteLine("Whooaaaaa, too old for computers");
            else if (_months == null)
                Console.WriteLine($"In {_diff} years you will be {oldAge}. You *might* be allowed to retire. Happy Birthday!");
            else
                Console.WriteLine($"In {(int)_diff} years and {_months} months you will be {oldAge}");
            Console.Read();
        }
        
    }
}
