namespace Exam.Models.AttackTypes
{
    using Interface;

    public abstract class AttackAbstract : IAttack
    {
        public int Damage { get; set; }
        public abstract void ProcessAttack(IBlob attackingBlob, IBlob targetBlob);

        public static void ValidateHelth(IBlob blob)
        {
            if (blob.Health < 0)
            {
                blob.Health = 0;
            }
        }
    }
}
