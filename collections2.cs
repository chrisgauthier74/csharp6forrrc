using System;
using System.Collections;
using static System.Console;


namespace Collections2
{
    class collections2
    {
        /// <summary>
        /// Hash Collection types
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            //these are objects and will need to unbox later to run through a foreach
            ht.Add(0, "0");
            ht.Add(1, "1");
            ht.Add(2, "2");

            foreach (DictionaryEntry de in ht)
            {
                //unbox the objects now so we can print them out
                //see the program on boxing and unboxing
                int key = (int)de.Key;
                string value = de.Value.ToString();

                WriteLine($"{key},{value}");

            }



    
         

        }
    }
}
