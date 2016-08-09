using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CH04EX04
{
    class logic1
    {
        static void Main(string[] args)
        {

            int i = 1;

            do
            {
                WriteLine($"i: {i}");
                i++;
            }
            while (i <= 10);
            
            for (int j=0; j<10; j++)
            {
                WriteLine($"j: {j}");
                i++;

            }

            for (int c = 0; c <=100; c++)
            {
                WriteLine($"c: {c}");

                if (c == 50)
                {
                    WriteLine("c is 50, breaking");
                    break;
                }
            }
        }
    }
}
