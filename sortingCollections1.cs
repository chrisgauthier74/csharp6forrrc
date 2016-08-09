using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections;


namespace sortingCollections
{
    public class Person : IComparable {

        public string Name;
        public int Age;

        public Person (string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object obj)
        {
            if (obj is Person)
            {
                Person otherPerson = obj as Person;
            }
            else
            {
                throw new ArgumentException("Object to compare to is not a person object");0
            }
        }

    }
}
