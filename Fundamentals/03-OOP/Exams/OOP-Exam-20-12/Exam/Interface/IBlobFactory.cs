namespace Exam.Interface
{
    public interface IBlobFactory
    {
        IBlob Create(string name, int damage, int health, IBehavior behavior, IAttack attackType);
    }
}
