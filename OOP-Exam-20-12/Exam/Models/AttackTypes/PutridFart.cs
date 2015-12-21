namespace Exam.Models.AttackTypes
{
    using Interface;

    public class PutridFart : AttackAbstract
    {
        public override void ProcessAttack(IBlob attackingBlob, IBlob targetBlob)
        {
            this.Damage = attackingBlob.Damage;
            targetBlob.Health -= this.Damage;
            ValidateHelth(targetBlob);
        }
    }
}
