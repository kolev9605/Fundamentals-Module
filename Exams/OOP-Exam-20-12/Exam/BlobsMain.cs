namespace Exam
{
    using Core;
    using Core.Engine;
    using Core.Factories;
    using Interface;
    using IO;

    public class BlobsMain
    {
        public static void Main(string[] args)
        {
            IUserInterface userInterface = new ConsoleUserInterface();
            IBlobFactory blobFactory = new BlobFactory();
            IBehaviorFactory behaviorFactory = new BehaviorFactory();
            IAttackFactory attackFactory = new AttackFactory();
            IDatabase database = new Database();

            IEngine engine = new Engine(userInterface,attackFactory,blobFactory,behaviorFactory,database);

            engine.Run();
        }
    }
}
