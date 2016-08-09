using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH062
{
    class usingSplit
    {
        /// <summary>
        /// This application takes two command line arguments, places them into a string and integer variable then displays the value
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number and a string, seperated by a coloumn");
            string input = ReadLine();
            string[] inputArray = input.Split(',');
            WriteLine($"{inputArray[0]}");
            WriteLine($"{inputArray[1]}");
        }
    }
}
