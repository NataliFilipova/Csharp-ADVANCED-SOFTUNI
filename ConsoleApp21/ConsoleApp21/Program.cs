using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp21
{
    class Student
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student> ();

            for(int i = 0; i <n; i++)
            {
                var tokens = Console.ReadLine().Split(" ");
                Student student = new Student();
                student.FirstName = tokens[0];
                student.LastName = tokens[1];
                student.Grade = double.Parse(tokens[2]);
                students.Add(student);
            }
            students = students.OrderByDescending(Student => Student.Grade).ToList();

            foreach(Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }
}
