namespace Exam.Models.AttackTypes
{
    using Interface;

    public class Blobplode : AttackAbstract
    {
        public override void ProcessAttack(IBlob attackingBlob, IBlob targetBlob)
        {
            attackingBlob.Health = attackingBlob.Health - attackingBlob.Health / 2;
            if (attackingBlob.Health < 1)
            {
                attackingBlob.Health = 1;
            }
            this.Damage = attackingBlob.Damage * 2;
            targetBlob.Health -= this.Damage;
            ValidateHelth(targetBlob);
        }
    }
}
