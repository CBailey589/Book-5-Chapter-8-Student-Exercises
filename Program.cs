using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
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

            JisieDavid.Assign(DomKantrude, KandyKorner);
            JisieDavid.Assign(BrianNeal, KandyKorner);
            JisieDavid.Assign(DomKantrude, Goldenrod);
            JisieDavid.Assign(BrianNeal, Goldenrod);

            JoeShepherd.Assign(AbbeyBrown, Goldenrod);
            JoeShepherd.Assign(JanetWoods, Goldenrod);
            JoeShepherd.Assign(AbbeyBrown, FollowTheMoney);
            JoeShepherd.Assign(JanetWoods, FollowTheMoney);


            Cohort30.Print();
            Cohort31.Print();
            Cohort32.Print();

        }
    }
}
