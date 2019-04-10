using System;
using System.Collections.Generic;

namespace myApp
{
    public class Instructor
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private string _slackHandle { get; set; }

        public Instructor(string fName, string lName, string position)
        {
            _firstName = fName;
            _lastName = lName;
            _slackHandle = position;
        }

        public void Assign(Student student, Exercise exercise)
        {
            student.SetAssignment(exercise);
        }


        public void Print()
        {
            Console.WriteLine($"{_firstName} {_lastName}");
        }

    }
}