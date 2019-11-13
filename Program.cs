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

            Student steve = new Student()
            {
                firstName = "Steve",
                lastName = "evetS",
                slackHandle = "Stevers",
                Cohort = cohortThree,
            };


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
            josh.AddExercise(lists, frank);
            josh.AddExercise(watched, frank);


            cohortOne.instructorsInCohortList.Add(jordan);
            cohortTwo.instructorsInCohortList.Add(instructorTommy);
            cohortThree.instructorsInCohortList.Add(josh);

            List<Student> students = new List<Student>();
            students.Add(alex);
            students.Add(sable);
            students.Add(frank);
            students.Add(tommy);
            students.Add(steve);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(classes);
            exercises.Add(lists);
            exercises.Add(watched);
            exercises.Add(dailyJournal);

            List<Instructor> instructors = new List<Instructor>(){
                instructorTommy, jordan, josh
            };

            List<Cohort> cohorts = new List<Cohort>(){
                cohortOne, cohortTwo, cohortThree
            };

            // List exercises for the JavaScript language by using the Where() LINQ method.

            IEnumerable<Exercise> JavascriptExercises = exercises.Where(exercises => exercises.language == "Javascript");

            // List students in a particular cohort by using the Where() LINQ method.

            IEnumerable<Student> studentsInCohortOne = students.Where(student => student.Cohort == cohortOne);

            // foreach (Student student in studentsInCohortOne)
            // {
            //     Console.WriteLine(student.firstName);
            // }

            // List instructors in a particular cohort by using the Where() LINQ method.

            IEnumerable<Instructor> instructorsInCohortOne = instructors.Where(instructor => instructor.Cohort == cohortOne);

            // foreach (Instructor instructor in instructorsInCohortOne)
            // {
            //     Console.WriteLine(instructor.firstName);
            // }

            // Sort the students by their last name.

            IEnumerable<Student> studentsSorted = students.OrderBy(student => student.lastName).ToList();


            // foreach (Student student in studentsSorted)
            // {
            //     Console.WriteLine(student.lastName);
            // }

            // Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)

            IEnumerable<Student> lazyBois = students.Where(student => student.currentExercises.Count == 0);

            // foreach (Student s in lazyBois)
            // {
            //     Console.WriteLine(s.firstName);
            // }

            IEnumerable<Student> studentsOrderedByCurrentExerciseCount = students.OrderByDescending(student => student.currentExercises.Count());

            Student hardestWorkinBoi = studentsOrderedByCurrentExerciseCount.Last();

            // Console.WriteLine(hardestWorkinBoi.firstName);

            // How many students in each cohort?

            IEnumerable<Cohort> cohortsOrderedByDescending = cohorts.OrderByDescending(cohorts => cohorts.studentsInCohortList.Count());

            foreach (Cohort cohort in cohortsOrderedByDescending)
            {
                Console.WriteLine($"{cohort.cohortName} has {cohort.studentsInCohortList.Count()} students in it!");
            }









            // foreach (Exercise currentExercise in exercises)
            // {
            //     Console.WriteLine(currentExercise.nameOfExercise);
            //     Console.WriteLine("---------");
            //     List<Student> assignedStudents = students.Where(singleStudent => singleStudent.currentExercises.Any(singleExercise => singleExercise.nameOfExercise == currentExercise.nameOfExercise)).ToList();

            //     assignedStudents.ForEach(singleStudent => Console.WriteLine(singleStudent.firstName));
            //     Console.WriteLine();
            // }
        }
    }
}
