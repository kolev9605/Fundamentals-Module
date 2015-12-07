using System;

namespace P04.SLUS
{
    class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currCourse) 
            : base(firstName, lastName, age, studentNumber, averageGrade, currCourse) { }
    }
}
