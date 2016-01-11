namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<string> students = new List<string>();

        protected Course(string name)
        {
            this.Name = name;
            this.TeacherName = null;
            this.Students = new List<string>();
        }

        protected Course(string courseName, string teacherName)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        protected Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Name cannot be null");
                }
                this.name = value;
            }
        }

        public string TeacherName
        {
            get { return this.teacherName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Teacher name cannot be null");
                }
                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get { return this.students; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Students cannot be null");
                }
                this.students = value;
            }
        }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}