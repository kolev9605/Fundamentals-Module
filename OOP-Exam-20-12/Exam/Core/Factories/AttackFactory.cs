namespace Exam.Core.Factories
{
    using Exceptions;
    using Interface;
    using Models.AttackTypes;

    public class AttackFactory : IAttackFactory
    {
        public IAttack CreateAttack(string attackName)
        {
            switch (attackName)
            {
                case "PutridFart":
                    return new PutridFart();
                case "Blobplode":
                    return new Blobplode();
                default:
                    throw new FactoryException(Messeges.NotSupportedAttack);
            }
        }
    }
}
