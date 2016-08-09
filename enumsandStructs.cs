using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace CH05EX01
{
    class enumsandStructs
    {
        /// <summary>
        /// enums
        /// </summary>
        enum orientation: byte
        {
            north = 1,
            south = 2,
            east = 3,
            west = 4
        }

        /// <summary>
        /// structs
        /// </summary>
        /// <param name="args"></param>
        /// 

        struct route
        {
            public orientation direction;
            public double distance;
        }

        static void Main(string[] args)
        {

            int[] numArray = { 0, 1, 2, 3, 4, 5 };
            string[] friendArray = { "Chris", "Paul", "Dallas" };

            for (int i = 1; i <= friendArray.Length; i++)
            {
                WriteLine($"Friend[{i}] = {friendArray[i]}");

            }
            foreach (int num in numArray)
            {
                Console.WriteLine($"num {num}");                
            }

            route myRoute;
            myRoute.distance = 10;
            WriteLine($"{myRoute.distance}");
            WriteLine($"{orientation.north}");
            WriteLine($"{orientation.south}");
            WriteLine($"{orientation.east}");
            WriteLine($"{orientation.west}");

        }
    }
}
