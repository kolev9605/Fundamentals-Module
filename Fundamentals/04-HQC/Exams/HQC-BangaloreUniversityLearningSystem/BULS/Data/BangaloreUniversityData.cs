namespace BangaloreUniversityLearningSystem.Data
{
    using Interfaces;
    using Models;

    public class BangaloreUniversityData : IBangaloreUniversityData
    {
        public BangaloreUniversityData()
        {
            this.UsersRepository = new UsersRepository();
            this.CoursesRepository = new Repository<Course>();
        }

        public UsersRepository UsersRepository { get; private set; }

        public IRepository<Course> CoursesRepository { get;  private set; }
    }
}
