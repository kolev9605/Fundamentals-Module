namespace Exam.Interface
{
    public interface IAttackFactory
    {
        IAttack CreateAttack(string attackName);
    }
}
