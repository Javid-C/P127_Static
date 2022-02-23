using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Static
{
    class Student
    {
        public int Id;
        public static int count=5;
        public static int total;
        public string Name;
        public string Surname;

        public Student(string name,string surname)
        {
            Console.WriteLine("normal");
            count++;
            Name = name;
            Surname = surname;
            Id = count;
        }

        static Student()
        {
            Console.WriteLine("Static");
        }


        public static int Calc(Student stu)
        {
            return count + stu.Id;
        }

        
    }
}
