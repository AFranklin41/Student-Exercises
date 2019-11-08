using System;
using System.Collections.Generic;
using System.Linq;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise classes = new Exercise();
            classes.id = 1;
            classes.nameOfExercise = "Classes in C#";
            classes.language = "C#";

            Exercise lists = new Exercise();
            lists.id = 2;
            lists.nameOfExercise = "Lists in C#";
            lists.language = "C#";

            Exercise dailyJournal = new Exercise();
            dailyJournal.id = 3;
            dailyJournal.nameOfExercise = "Daily Journal";
            dailyJournal.language = "Javascript";

            Exercise watched = new Exercise();
            watched.id = 4;
            watched.nameOfExercise = "Watched";
            watched.language = "React";

            Cohort cohortOne = new Cohort();
            cohortOne.id = 1;
            cohortOne.cohortName = "Cohort One";

            Cohort cohortTwo = new Cohort();
            cohortTwo.id = 2;
            cohortTwo.cohortName = "Cohort Two";

            Cohort cohortThree = new Cohort();
            cohortThree.id = 3;
            cohortThree.cohortName = "Cohort Three";

            Student alex = new Student()
            {
                id = 1,
                firstName = "Alex",
                lastName = "Franklin",
                slackHandle = "Alex Franklin",
                Cohort = cohortTwo,
                // cohortTwo.studentsInCohortList.Add(alex);
            };

            Student sable = new Student();
            sable.id = 2;
            sable.firstName = "Sable";
            sable.lastName = "SAAAAAAAABLE";
            sable.slackHandle = "Sabs";
            sable.Cohort = cohortOne;
            // cohortOne.studentsInCohortList.Add(sable);

            Student tommy = new Student();
            tommy.id = 3;
            tommy.firstName = "Tommy";
            tommy.lastName = "Ymmot";
            tommy.slackHandle = "TomTom";
            tommy.Cohort = cohortOne;
            // cohortOne.studentsInCohortList.Add(tommy);

            Student frank = new Student();
            frank.id = 4;
            frank.firstName = "Frank";
            frank.lastName = "Knarf";
            frank.slackHandle = "FrankenFrank";
            frank.Cohort = cohortThree;
            // cohortThree.studentsInCohortList.Add(frank);


            cohortTwo.studentsInCohortList.Add(alex);
            cohortOne.studentsInCohortList.Add(sable);
            cohortOne.studentsInCohortList.Add(tommy);
            cohortThree.studentsInCohortList.Add(frank);

            Instructor jordan = new Instructor();
            jordan.id = 1;
            jordan.firstName = "Jordan";
            jordan.lastName = "Nadroj";
            jordan.Cohort = cohortOne;
            jordan.slackHandle = "Jordan";
            jordan.specialty = "Wizardry";
            // cohortOne.instructorsInCohortList.Add(jordan);
            jordan.AddExercise(watched, sable);
            jordan.AddExercise(lists, tommy);



            Instructor instructorTommy = new Instructor();
            instructorTommy.id = 2;
            instructorTommy.firstName = "Tommy";
            instructorTommy.lastName = "Ymmot";
            instructorTommy.Cohort = cohortTwo;
            instructorTommy.slackHandle = "Tommmmmmmy";
            instructorTommy.specialty = "Specialized in Charisma";
            // cohortTwo.instructorsInCohortList.Add(instructorTommy);
            instructorTommy.AddExercise(watched, alex);
            instructorTommy.AddExercise(lists, alex);


            Instructor josh = new Instructor();
            josh.id = 1;
            josh.firstName = "Josh";
            josh.lastName = "Hsoj";
            josh.Cohort = cohortThree;
            josh.slackHandle = "Joshington";
            josh.specialty = "Beard";
            // cohortThree.instructorsInCohortList.Add(josh);
            josh.AddExercise(classes, frank);
            josh.AddExercise(dailyJournal, frank);


            cohortOne.instructorsInCohortList.Add(jordan);
            cohortTwo.instructorsInCohortList.Add(instructorTommy);
            cohortThree.instructorsInCohortList.Add(josh);

            List<Student> students = new List<Student>();
            students.Add(alex);
            students.Add(sable);
            students.Add(frank);
            students.Add(tommy);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(classes);
            exercises.Add(lists);
            exercises.Add(watched);
            exercises.Add(dailyJournal);


            foreach (Exercise currentExercise in exercises)
            {
                Console.WriteLine(currentExercise.nameOfExercise);
                Console.WriteLine("---------");
                List<Student> assignedStudents = students.Where(singleStudent => singleStudent.currentExercises.Any(singleExercise => singleExercise.nameOfExercise == currentExercise.nameOfExercise)).ToList();

                assignedStudents.ForEach(singleStudent => Console.WriteLine(singleStudent.firstName));
                Console.WriteLine();
            }
        }
    }
}
