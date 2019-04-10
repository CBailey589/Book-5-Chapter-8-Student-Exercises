using System;
using System.Collections.Generic;

namespace myApp
{
    public class Cohort
    {
        private string _name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();

        public Cohort(string name)
        {
            _name = name;
        }

        public void Enroll(Student student)
        {
            Students.Add(student);
        }

        public void Employ(Instructor instructor){
            Instructors.Add(instructor);
        }
        public void Print()
        {
            Console.WriteLine($@"
Name: {_name}
---------------------------
Instructors:
            ");

            foreach (Instructor Instructor in Instructors)
            {
                Instructor.Print();
            }

            Console.WriteLine($@"
---------------------------
Students:
            ");

            foreach(Student Student in Students)
            {
                Student.Print();
            }
        }
    }
}