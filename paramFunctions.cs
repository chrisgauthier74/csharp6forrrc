using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH06EX03
{
    class paramFunctions
    {
        //parameter arrays
        //array passed right into the function without declaring an array of ints
        static int SumVals(params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;

            }
            return sum;
        }

        static void Main(string[] args)
        {
            int sum = SumVals(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            WriteLine($"Sum Value: {sum}");
        }
    }
}
