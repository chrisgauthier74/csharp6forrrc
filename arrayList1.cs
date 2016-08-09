using System;
using System.Collections;
using static System.Console;

namespace collections
{
    class arrayList1
    {
        static void Main(string[] args)
        {   //initializes a new arraylist with 0 space for objects
            ArrayList newArrayList = new ArrayList();
            //start up a for loop
            for (int i=0; i <=10; i++)
            {
                //fill the arraylist up
                newArrayList.Add(i);
            }
            //write out the capacity of the array list.
            //note that the capacity is 16.  That's because the arraylist interface creates space for 4 elements by default, then when 5 comes along, it creates another
            //4 and when 8 hits, another 8 etc
            WriteLine("ArrayList has: " + newArrayList.Capacity );

            //this is costly and wasteful use of memory -- you have more space in memory than you need.  Therefore, this is a better practice

            ArrayList betterArrayList = new ArrayList(10);
            WriteLine("betterArrayList has " + betterArrayList.Capacity);

            //another technique to manage memory
            ArrayList trimArray = new ArrayList();
            for (int i=0; i <=10; i++)
            {
                trimArray.Add(i);
            }
            trimArray.TrimToSize();
            WriteLine($"Trimmed array should be 11: {trimArray.Capacity}");
            
            //now lets print everything out

            foreach (int s in trimArray)
            {
                WriteLine($"Int in trimArray: {s}");
            }

            //now lets print one object out
            WriteLine($"trimArray[3]: {trimArray[3]}");

            //using insert -- inserts where you want it in the arrayList

            trimArray.Insert(3, 1);

            foreach (int s in trimArray)
            {
                WriteLine($"trimArray[s]: {s}");

            }

            //remove and removeat

            trimArray.Remove(0);
            WriteLine($"removing[0]");
            foreach (int s in trimArray)
            {
                WriteLine($"items in trimArray: {s}");

            }


            trimArray.RemoveAt(1);
            WriteLine($"removing[1]");
            foreach (int s in trimArray)
            {
                WriteLine($"items in trimArray: {s}");

            }

            //sort with trimArray.Sort()
            //reverse with trimArray.Reverse()




        }
    }
}
