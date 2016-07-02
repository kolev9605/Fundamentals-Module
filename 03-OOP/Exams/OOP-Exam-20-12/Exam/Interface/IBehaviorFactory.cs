namespace Exam.Interface
{
    public interface IBehaviorFactory
    {
        IBehavior CreateBehavior(string behaviorName, IUserInterface userInterface);
    }
}
