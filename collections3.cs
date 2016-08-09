using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections;

namespace collections3
{

    class Animal : DictionaryBase
    {
        public void Add(string newID, Animal newAnimal)
        {
            Dictionary.Add(newID, newAnimal);
        }

        public void Remove (Animal removeAnimal)
        {
            Dictionary.Remove(removeAnimal);
        }

        public Animal () { }

        public Animal this[string animalID]
        {
            get {  return (Animal) Dictionary[animalID]} 
            set { Dictionary[animalID] = value; }
        }
        static void Main(string[] args)
        {
        }
    }
}
