using System;
using System.Collections.Generic;

namespace myApp
{
    public class Student
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private string _slackHandle { get; set; }
        private string _cohort { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();

        public Student(string fName, string lName, string position)
        {
            _firstName = fName;
            _lastName = lName;
            _slackHandle = position;
        }

        public void SetAssignment(Exercise exercise)
        {
            Exercises.Add(exercise);
        }

        public void GetEnrolled(string taco) {
            _cohort = taco;
        }

        public string returnCohort(){
            return _cohort;
        }

        public string returnLastName(){
            return _lastName;
        }
        public void Print()
        {
            Console.WriteLine($@"{_firstName} {_lastName}:
            Exercises:");

            foreach (Exercise Exercise in Exercises)
            {
                Exercise.Print();
            }

            Console.WriteLine("");
        }

    }
}
