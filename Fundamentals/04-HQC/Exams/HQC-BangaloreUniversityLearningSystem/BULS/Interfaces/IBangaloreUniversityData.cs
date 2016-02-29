namespace BangaloreUniversityLearningSystem.Interfaces
{
    using Data;
    using Models;

    public interface IBangaloreUniversityData
    {
        UsersRepository UsersRepository { get; }

        IRepository<Course> CoursesRepository { get; }
    }
}