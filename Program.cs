using System;
using System.Collections.Generic;
using System.Linq;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // STUDENT EXERCISES 1 *****************************************************************************************

            // Create 4, or more, exercises.
            Exercise FollowTheMoney = new Exercise("FollowTheMoney", "JavaScript");
            Exercise Goldenrod = new Exercise("Goldenrod", "CSS");
            Exercise KandyKorner = new Exercise("KandyKorner", "ReactJS");
            Exercise NSSKennel = new Exercise("NSS Kennel", "ReactJS");


            // Create 3, or more, cohorts
            Cohort Cohort30 = new Cohort("Cohort 30");
            Cohort Cohort31 = new Cohort("Cohort 31");
            Cohort Cohort32 = new Cohort("Cohort 32");

            // Create 4, or more, students and assign them to one of the cohorts.
            Student ConnorBailey = new Student("Connor", "Bailey", "CBailey");
            Student SamCronin = new Student("Sam", "Cronin", "SCronin");
            Student DomKantrude = new Student("Dom", "Kantrude", "DKantrude");
            Student BrianNeal = new Student("Brian", "Neal", "BNeal");
            Student AbbeyBrown = new Student("Abbey", "Brown", "ABrown");
            Student JanetWoods = new Student("Janet", "Woods", "JWoods");

            Cohort30.Enroll(ConnorBailey);
            Cohort30.Enroll(SamCronin);
            Cohort31.Enroll(DomKantrude);
            Cohort31.Enroll(BrianNeal);
            Cohort32.Enroll(AbbeyBrown);
            Cohort32.Enroll(JanetWoods);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor SteveBrownlee = new Instructor("Steve", "Brownlee", "SBrownlee");
            Instructor JisieDavid = new Instructor("Jisie", "David", "JDavid");
            Instructor JoeShepherd = new Instructor("Joe", "Shepherd", "JShepherd");

            Cohort30.Employ(SteveBrownlee);
            Cohort31.Employ(JisieDavid);
            Cohort32.Employ(JoeShepherd);

            // Have each instructor assign 2 exercises to each of the students.
            SteveBrownlee.Assign(ConnorBailey, NSSKennel);
            SteveBrownlee.Assign(SamCronin, NSSKennel);
            SteveBrownlee.Assign(ConnorBailey, KandyKorner);
            SteveBrownlee.Assign(SamCronin, KandyKorner);
            SteveBrownlee.Assign(ConnorBailey, Goldenrod);

            JisieDavid.Assign(DomKantrude, KandyKorner);
            JisieDavid.Assign(BrianNeal, KandyKorner);
            JisieDavid.Assign(DomKantrude, Goldenrod);
            JisieDavid.Assign(BrianNeal, Goldenrod);
            JisieDavid.Assign(DomKantrude, NSSKennel);

            JoeShepherd.Assign(AbbeyBrown, Goldenrod);
            JoeShepherd.Assign(JanetWoods, Goldenrod);
            JoeShepherd.Assign(AbbeyBrown, FollowTheMoney);
            JoeShepherd.Assign(JanetWoods, FollowTheMoney);


            // Cohort30.Print();
            // Cohort31.Print();
            // Cohort32.Print();

            // Student Exercises 2 *****************************************************************************************


            List<Student> students2 = new List<Student>(){
                ConnorBailey, SamCronin, DomKantrude, BrianNeal, AbbeyBrown, JanetWoods
            };
            List<Exercise> exercises2 = new List<Exercise>(){
                FollowTheMoney, Goldenrod, KandyKorner, NSSKennel
            };
            List<Instructor> instructors2 = new List<Instructor>() {
            SteveBrownlee, JisieDavid, JoeShepherd
            };
            List<Cohort> cohorts2 = new List<Cohort>() {
                Cohort30, Cohort31, Cohort32
            };

            // List exercises for the JavaScript language by using the Where() LINQ method.
            List<Exercise> JSExercises = exercises2
            .Where(ex => ex.returnLang() == "JavaScript")
            .ToList();
            foreach (Exercise ex in JSExercises)
            {
                ex.Print();
            }
            //  List students in a particular cohort by using the Where() LINQ method.
            List<Student> C30Students = students2
            .Where(st => st.returnCohort() == "Cohort 30")
            .ToList();
            foreach (Student st in C30Students)
            {
                st.Print();
            }

            // List instructors in a particular cohort by using the Where() LINQ method.
            List<Instructor> C30Instructor = instructors2
            .Where(inst => inst.returnCohort() == "Cohort 30")
            .ToList();
            foreach (Instructor inst in C30Instructor)
            {
                inst.Print();
            }

            // Sort the students by their last name.
            List<Student> StudentsByLastName = students2
            .OrderBy(st => st.returnLastName())
            .ToList();
            foreach (Student st in StudentsByLastName)
            {
                Console.WriteLine($"{st.returnLastName()}");
            }

            // Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            Student LazyKid = new Student("Lazy", "Kid", "LaZKid");
            students2.Add(LazyKid);
            List<Student> StudentsWithNoExercises = students2
            .Where(st => st.Exercises.Count() == 0)
            .ToList();
            foreach (Student st in StudentsWithNoExercises)
            {
                st.Print();
            }

            // Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            List<Student> StudentsWithMostExercises = students2
            .Where(st => st.Exercises.Count() == (students2.Max(stud => stud.Exercises.Count())))
            .ToList();
            foreach (Student st in StudentsWithMostExercises)
            {
                st.Print();
            }

            // How many students in each cohort?
            foreach (Cohort co in cohorts2)
            {
                Console.WriteLine($"Cohort {co.returnName()} has {co.Students.Count()} students");
            }

            // Student Exercises 3 *****************************************************************************************
            












        }
    }
}
