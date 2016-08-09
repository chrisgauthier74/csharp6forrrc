using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication1
{
    class Student 
    {   
        /// <summary>
        /// App to demonstrate operator overloading
        /// </summary>
        public int grade;
        public int id;

        public Student(int id, int grade )
        {
            WriteLine($"Creating a student{id} !");
            this.id = id;
            this.grade = grade;
        }
        public void Display ()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Grade: {grade}");

        }

        public static Student operator +(Student s1, Student s2) {
            Student newStudent = new Student(s1.id + s2.id,s1.grade + s2.grade);
            return newStudent;
        }

    }
    class operatorOverloading1
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(5,95);
            Student s2 = new Student(10, 80);
            s1.Display();
            s2.Display();

            Student s3 = s1 + s2;
            s3.Display();


        }
    }
}
