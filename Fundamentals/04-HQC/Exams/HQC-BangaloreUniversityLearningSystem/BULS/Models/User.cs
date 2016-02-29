namespace BangaloreUniversityLearningSystem.Models
{
    using System;
    using System.Collections.Generic;
    using Infrastructure;
    using Utilities;

    public class User
    {
        private string username;
        private string passwordHash;

        public User(string username, string password, Role role)
        {
            this.Username = username;
            this.PasswordHash = password;
            this.Role = role;
            this.Courses = new List<Course>();
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    string message = string.Format(Constants.UsernameValidationMessage, Constants.UsernameMaxLenght);
                    throw new ArgumentException(message);
                }

                if (value.Length < 5)
                {
                    string message = string.Format(Constants.UsernameValidationMessage, Constants.UsernameMaxLenght);
                    throw new ArgumentException(message);
                }

                this.username = value;
            }
        }

        public string PasswordHash
        {
            get
            {
                return this.passwordHash;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    string message = string.Format(Constants.PasswordValidationMessage, Constants.PasswordMaxLenght);
                    throw new ArgumentException(message);
                }

                if (value.Length < 6)
                {
                    string message = string.Format(Constants.PasswordValidationMessage, Constants.PasswordMaxLenght);
                    throw new ArgumentException(message);
                }

                this.passwordHash = HashUtilities.HashPassword(value);
            }
        }

        public Role Role { get; private set; }

        public IList<Course> Courses { get; private set; }
    }
}