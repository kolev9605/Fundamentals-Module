﻿namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name)
            : base(name)
        {
        }

        public LocalCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
        }

        public string Lab
        {
            get { return this.lab; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Lab name cannot be null");
                }
                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse { Name = ");
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}