namespace Exam.Interface
{
    public interface IAttackable
    {
        int Damage { get; set; }
        int InitialDamage { get;}
        void Attack(IBlob target);
    }
}
