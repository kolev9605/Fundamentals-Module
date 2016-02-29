namespace Exam.Interface
{
    public interface IKillable
    {
        int Health { get; set; }
        int InitialHealth { get; }
        bool IsAlive { get; set; }
    }
}
