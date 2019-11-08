using System.Collections.Generic;

namespace student_exercises
{
    class Exercise
    {
        //     You must define a type for representing an exercise in code.An exercise can be assigned to many students.

        //    Name of exercise
        //    Language of exercise (JavaScript, Python, CSharp, etc.)

        public int id { get; set; }
        public string nameOfExercise { get; set; }
        public string language { get; set; }
    }
}