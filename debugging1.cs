using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace CH07EX1
{
    class debugging1
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7 };
            int[] maxValIndices;
            int maxVal = Max(testArray, out maxValIndices);

            WriteLine($"maximum value {maxVal} found at element indices:");
            foreach (int index in maxValIndices)
            {
                WriteLine(index);

            }
            ReadKey();
        }


        static int Max(int[] integers, out int[] indices)
        {
            Debug.WriteLine("Maximum value search started");
            indices = new int[1];
            int maxVal = integers[0];
            indices[0] = 0;
            int count = 1;

            Debug.WriteLine(string.Format($"Maximum value intialized to {maxVal}, at element index 0."));
            for (int i = 1; i < integers.Length; i++)
            {
                Debug.WriteLine(string.Format($"Now looking at element at index {i}."));
                if (integers[i] > maxVal)
                {
                    maxVal = integers[i];
                    count = 1;
                    indices = new int[1];
                    indices[0] = i;
                    Debug.WriteLine(string.Format($"New maximum found.  New value is {maxVal}, at element index {i}."));
                }
                else
                {
                    if (integers[i] == maxVal)
                    {
                        count++;
                        int[] oldIndices = indices;
                        indices = new int[count];
                        oldIndices.CopyTo(indices, 0);
                        indices[count = 1] = i;
                        Debug.WriteLine(string.Format($"Duplicate maxmum found at element index{i}."));

                    }
                 
                }
                
            }
            Trace.WriteLine(string.Format($"maxmum value {maxVal} found, with {count} occurences."));
            Debug.WriteLine("maximum value search completed.");
            return maxVal;

        }

    }
}
