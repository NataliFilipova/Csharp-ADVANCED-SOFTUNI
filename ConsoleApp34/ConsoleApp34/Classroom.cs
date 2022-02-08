using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        public List<Student> Students { get; set; }
        public int Capacity { get; set; }
        public int Count => Students.Count;

        public Classroom(int capacity)
        {

            Capacity = capacity;
            Students = new List<Student>(capacity);
        }

        public string RegisterStudent(Student student)
        {

            if (Students.Count < Capacity)
            {

                Students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";

            }
            else
            {
                return $"No seats in the classroom";
            }


        }

        public string DismissStudent(string firstName, string lastName)
        {


            foreach (Student student in Students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {

                    Students.Remove(student);
                    return $"Dismissed student {firstName} {lastName}";

                }
            }

            return "Student not found";



        }
        public string GetSubjectInfo(string subject)
        {

            if (Students.Any(s => s.Subject == subject))
            {
                var sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
               
                sb.AppendLine($"Students:");


                foreach (Student student in Students)
                {
                    if (student.Subject == subject)
                    {
                       
                        sb.AppendLine($"{student.FirstName} {student.LastName}");

                    }
                   
                }
                return sb.ToString().TrimEnd();
            }

            return $"No students enrolled for the subject";


        }

        public int GetStudentsCount()
        {
            return Count;
        }
        public Student GetStudent(string firstName, string lastName)
        {

            var student = Students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            return student;

        }
    }
}