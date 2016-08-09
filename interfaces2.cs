using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace interfaces2
{
    interface myInterface1
    {
        void Print(string x);

    } 

    interface myInterface2
    {
        void Print2(string x);
    }


    class interfaces2 : myInterface1, myInterface2
    {
        //must implement Print from the myinterface1 definition
        public void Print(string x)
        {
            WriteLine($"in Print, {x}");
        }

        //must implement print2() from the myinterface2 definition
        public void Print2(string x)
        {
            WriteLine($"in Print2, {x}");
        }
        static void Main(string[] args)
        {
            String a = "My Interface 1 string";
            String b = "My Interface 2 string";

            Program myint1 = new Program();
            myint1.Print(a);
            myint1.Print2(b);


            
        }

    }
}
