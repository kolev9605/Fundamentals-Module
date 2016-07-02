namespace Exam.Interface
{
    public interface IAttack
    {
        int Damage { get; set; }
        void ProcessAttack(IBlob attackingBlob, IBlob targetBlob);
    }
}
