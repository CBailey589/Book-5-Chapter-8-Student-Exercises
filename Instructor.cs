using System;
using System.Collections.Generic;

namespace myApp
{
    public class Instructor : NSSPerson
    {
        public Instructor(string fName, string lName, string position)
        {
            FirstName = fName;
            LastName = lName;
            SlackHandle = position;
        }

        public void Assign(Student student, Exercise exercise)
        {
            student.SetAssignment(exercise);
        }
        public void GetEmployed(string taco)
        {
            Cohort = taco;
        }

        public string returnCohort()
        {
            return Cohort;
        }


        public void Print()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

    }
}