
using System.Collections.Generic;

namespace student_exercises
{
    class Instructor
    {
        // First name
        // Last name
        // Slack handle
        // The instructor's cohort
        // The instructor's specialty (e.g. jokes, snack cakes, dancing, etc.)
        // A method to assign an exercise to a student

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public int id { get; set; }
        public string specialty { get; set; }

        public void AddExercise(Exercise exerciseToAdd, Student studentToAdd)
        {
            studentToAdd.currentExercises.Add(exerciseToAdd);
        }
    }
}