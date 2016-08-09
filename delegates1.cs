using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace delegates1
{
    class delegates1
    {
        delegate void myDelegate(string s);


        //using anonymous functions
        delegate void printIntFunction();
        delegate void printStaticInt(int x);

        public static void Main (string[] args)
        {
            

            myDelegate del1 = new myDelegate(testFunction);
            //this syntax works too without the amount of code necessary to instantiate a delegate
            myDelegate del2 = testFunction;

            del1("Hello World 1");
            del2("hello world 2\n");
            //using an anonmyous function

            printIntFunction printDel = delegate
            {
                for (int i = 0; i <= 5; i++)
                {
                    WriteLine($"i: {i}");
                }

            };
            //creating an anonymous function that takes a type
            printStaticInt printDel2 = delegate (int x)
            {
                for (int i = 0; i <= 5; i++)
                {
                    WriteLine($"x: {x}");
                }
            };
            int y = 10;
            printDel();
     
            printDel2(y);


        }

        static void testFunction(string s)
        {
            WriteLine($"My String is: {s}");
        }
    }
}
