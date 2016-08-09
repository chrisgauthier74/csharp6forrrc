using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH06EX4
{
    class stuct2
    {
        struct order
        {
            public string ItemName;
            public int unitCount;
            public double unitCost;
            public double printCost() => unitCount * unitCost;
            public string formatCost() => "Order Information: " + unitCount.ToString() + " " + ItemName + " items at $" + unitCost.ToString() + " each, total cost $" + printCost().ToString() ;
        }

        struct Customer
        {
            public string firstName, lastName;

            public string printName() => firstName + " " + lastName;
        }

        static void Main(string[] args)
        {
            order order1;
            order1.ItemName = "Test Product";
            order1.unitCount = 2;
            order1.unitCost = 10;
            WriteLine (order1.formatCost());


            Customer CustomerName;
            CustomerName.firstName = "Chris";
            CustomerName.lastName = "Gauthier";
            WriteLine(CustomerName.printName());

        }
    }
}
