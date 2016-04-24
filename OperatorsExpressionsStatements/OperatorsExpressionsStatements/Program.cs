using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            int x, y, a, b;

            //Assignment Operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            //There are many mathematical operators...

            //Addition Operator
            x = 3 + 4;

            //Subtraction Operator
            x = 4 - 3;

            //Multiplication Operator
            x = 10 * 5;

            //Division Operator
            x = 10 / 5;

            //Order of operations using parentheses
            x = (x + y) * (a - b);

            //There are many operators used to evaluate values...

            //Equality Operator
            if (x == y)
            {
            }

            //Greater than Operator
            if (x > y)
            {
            }

            //Less than Operator
            if (x < y)
            {
            }

            //Greator or equal to Operator
            if (x >= y)
            {
            }

            //Less than or equal to Operator
            if (x <= y)
            {
            }

            //There are two "conditional" operators as well that can be used
            //to expand / enhance an evaluation and they can be combined
            //together multiple times.

            //Conditional AND operator
            if ((x > y) && (a > b))
            {
            }

            //Conditional OR operator
            if ((x > y) || (a > b))
            {
            }

            //Here is the in-line conditional operator we used in a previous
            //lesson...

            string message = (x == 1) ? "Car" : "Boat";

            //Member access and Method invocation
            Console.WriteLine("Hi");

        }
    }
}
