namespace Exam.Core.Factories
{
    using Interface;
    using Models;

    public class BlobFactory : IBlobFactory
    {
        public IBlob Create(string name, int damage, int health, IBehavior behavior, IAttack attackType, bool printEvents, IUserInterface userInterface)
        {
            var blob = new Blob(damage, health, name, behavior, attackType, printEvents, userInterface);

            return blob;
        }
    }
}
