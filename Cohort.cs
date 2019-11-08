using System.Collections.Generic;

namespace student_exercises
{
    class Cohort
    {
        //         The cohort's name (Evening Cohort 6, Day Cohort 25, etc.)
        // The collection of students in the cohort.
        // The collection of instructors in the cohort.

        public string cohortName { get; set; }
        public int id { get; set; }
        public List<Student> studentsInCohortList = new List<Student>();
        public List<Instructor> instructorsInCohortList = new List<Instructor>();
    }
}