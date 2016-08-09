using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace iterators
{
    class interators
    {
        public static IEnumerable SimpleList()
        {
            for (int i=0; i <=10; i++)
            {
                yield return i;
            }

        }
        static void Main(string[] args)
        {
            foreach (int i in SimpleList() )
            {
                WriteLine($"i: {i}");
            }
        }
    }
}
