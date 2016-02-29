namespace Methods
{
    using System;

    public class Student
    {
        private DateTime dateOfBirth;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public DateTime DateOfBirth
        {
            get
            {
                this.dateOfBirth = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));

                return this.dateOfBirth;
            }
        }

        public bool IsOlderThan(Student otherStudent)
        {
            DateTime firstDate = this.DateOfBirth;
            DateTime secondDate = otherStudent.DateOfBirth;
            return firstDate > secondDate;
        }
    }
}