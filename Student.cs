using System;
using System.Collections.Generic;

namespace myApp
{
    public class Student : NSSPerson
    {
        public List<Exercise> Exercises = new List<Exercise>();

        public Student(string fName, string lName, string position)
        {
            FirstName = fName;
            LastName = lName;
            SlackHandle = position;
        }

        public void SetAssignment(Exercise exercise)
        {
            Exercises.Add(exercise);
        }

        public void GetEnrolled(string taco) {
            Cohort = taco;
        }

        public string returnCohort(){
            return Cohort;
        }

        public string returnLastName(){
            return LastName;
        }
        public void Print()
        {
            Console.WriteLine($@"{FirstName} {LastName}:
            Exercises:");

            foreach (Exercise Exercise in Exercises)
            {
                Exercise.Print();
            }

            Console.WriteLine("");
        }

    }
}
