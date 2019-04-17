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

        public string returnName()
        {
            return _name;
        }

        public void Enroll(Student student)
        {
            Students.Add(student);
            student.GetEnrolled(this._name);
        }

        public void Employ(Instructor instructor)
        {
            Instructors.Add(instructor);
            instructor.GetEmployed(this._name);
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

            foreach (Student Student in Students)
            {
                Student.Print();
            }
        }
    }
}