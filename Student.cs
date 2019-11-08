using System.Collections.Generic;

namespace student_exercises
{
    class Student
    {
        //         Properties
        // First name
        // Last name
        // Slack handle
        // The student's cohort
        // The collection of exercises that the student is currently working on
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> currentExercises = new List<Exercise>();
    }
}