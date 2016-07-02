using System;
using System.Collections.Generic;
using System.Linq;

namespace Exceptions_Homework
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private IList<Exam> exams;
        private readonly IList<ExamResult> results;

        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
            this.results = new List<ExamResult>();
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(this.firstName), "Invalid first name!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(this.lastName), "Invalid last name!");
                }
                this.lastName = value;
            }
        }

        public IList<Exam> Exams
        {
            get
            {
                return this.exams;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(this.lastName), "Invalid exams!");
                }
                this.exams = value;
            }
        }

        public IList<ExamResult> CheckExams()
        {
            if (this.Exams.Count == 0)
            {
                throw new ArgumentNullException("The student has no exams!");
            }
            
            foreach (Exam exam in this.Exams)
            {
                this.results.Add(exam.Check());
            }

            return this.results;
        }

        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                throw new InvalidOperationException("Cannot calculate average on missing exams");
            }

            if (this.Exams.Count == 0)
            {
                throw new InvalidOperationException("There are no exams.");
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}