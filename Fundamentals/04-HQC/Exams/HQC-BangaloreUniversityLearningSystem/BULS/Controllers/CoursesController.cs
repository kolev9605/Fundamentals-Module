namespace BangaloreUniversityLearningSystem.Controllers
{
    using System;
    using System.Linq;
    using System.Security.Authentication;
    using Infrastructure;
    using Interfaces;
    using Models;
    using Utilities;

    public class CoursesController : Controller
    {
        public CoursesController(IBangaloreUniversityData data, User user)
        {
            this.Data = data;
            this.CurrentUser = user;
        }

        public IView All()
        {
            return this.View(this.Data.CoursesRepository.GetAll().OrderBy(c => c.Name).ThenByDescending(c => c.Students.Count));
        }

        public IView Details(int courseId)
        {
            this.ValidateLoggedUser();
            this.EnsureAuthorization(Role.Student, Role.Lecturer);

            var course = this.Data.CoursesRepository.Get(courseId);
            if (course == null)
            {
                throw new ArgumentException(string.Format("There is no course with ID {0}.", courseId));
            }

            if (!this.CurrentUser.Courses.Contains(course))
            {
                throw new ArgumentException("You are not enrolled in this course.");
            }

            return this.View(course);
        }

        public IView Enroll(int courseId)
        {
            this.EnsureAuthorization(Role.Student, Role.Lecturer);
            var course = this.Data.CoursesRepository.Get(courseId);
            if (course == null)
            {
                throw new ArgumentException(string.Format("There is no course with ID {0}.", courseId));
            }

            if (this.CurrentUser.Courses.Contains(course))
            {
                throw new ArgumentException("You are already enrolled in this course.");
            }

            course.AddStudent(this.CurrentUser);
            return this.View(course);
        }

        public IView Create(string name)
        {
            this.ValidateLoggedUser();
            this.ValidatePremissions();

            var course = new Course(name);
            this.Data.CoursesRepository.Add(course);

            return this.View(course);
        }

        public IView AddLecture(int courseId, string lectureName)
        {
            this.ValidateLoggedUser();
            this.ValidatePremissions();

            Course c = this.GetCourseById(courseId);
            c.AddLecture(new Lecture(lectureName));

            return this.View(c);
        }

        private Course GetCourseById(int id)
        {
            var course = this.Data.CoursesRepository.Get(id);
            if (course == null)
            {
                throw new ArgumentException(string.Format("There is no course with ID {0}.", id));
            }

            return course;
        }

        private void ValidateLoggedUser()
        {
            if (!this.HasLoggedUser)
            {
                throw new ArgumentException("There is no currently logged in user.");
            }
        }

        private void ValidatePremissions()
        {
            if (!this.CurrentUser.IsInRole(Role.Lecturer))
            {
                throw new AuthenticationException("The current user is not authorized to perform this operation.");
            }
        }
    }
}
