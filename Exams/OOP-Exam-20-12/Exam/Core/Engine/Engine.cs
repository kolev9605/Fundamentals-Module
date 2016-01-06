namespace Exam.Core.Engine
{
    using System;
    using System.Linq;
    using Exceptions;
    using Interface;

    class Engine : IEngine
    {
        private readonly IUserInterface userInterface;
        private readonly IAttackFactory attackFactory;
        private readonly IBlobFactory blobFactory;
        private readonly IBehaviorFactory behaviorFactory;
        private readonly IDatabase database;

        private bool printEvents;

        public Engine(IUserInterface userInterface, IAttackFactory attackFactory, IBlobFactory blobFactory, IBehaviorFactory behaviorFactory, IDatabase database)
        {
            this.userInterface = userInterface;
            this.attackFactory = attackFactory;
            this.blobFactory = blobFactory;
            this.behaviorFactory = behaviorFactory;
            this.database = database;
            this.printEvents = false;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string[] inputParams = this.userInterface.ReadLine().Split(' ');
                    ExecuteCommand(inputParams);
                }
                catch (CommandException ex)
                {
                    throw new CommandException(ex.Message);
                }
                UpdateBlobs();
            }
        }

        private void UpdateBlobs()
        {
            var blobs = this.database.Blobs.Where(x=> x.IsAlive == true);
            foreach (var blob in blobs)
            {
                blob.Update();
            }
        }

        private void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    ExecuteCreateBlobCommand(inputParams);
                    break;
                case "attack":
                    ExecuteAttackCommand(inputParams);
                    break;
                case "pass":
                    break;
                case "status":
                    ExecuteBlobsStatusCommand();
                    break;
                case "drop":
                    Environment.Exit(0);
                    break;
                case "report-events":
                    ExecuteReportEventsCommand();
                    break;
                default:
                    throw new CommandException(Messeges.NotSupportedCommand);
            }
        }

        private void ExecuteReportEventsCommand()
        {
            this.printEvents = true;
        }

        private void ExecuteAttackCommand(string[] inputParams)
        {
            var attacker = this.database.Blobs.FirstOrDefault(x => x.Name == inputParams[1]);
            var target = this.database.Blobs.FirstOrDefault(x => x.Name == inputParams[2]);
            if (attacker == null || target == null)
            {
                throw new NullReferenceException(Messeges.NullBlobReference);
            }
            if (attacker.IsAlive == false || target.IsAlive == false)
            {
                throw new BlobException(Messeges.DeadBlob);
            }
            attacker.Attack(target);
        }

        private void ExecuteBlobsStatusCommand()
        {
            foreach (var blob in this.database.Blobs)
            {
                this.userInterface.WriteLine(blob.ToString());
            }
        }

        private void ExecuteCreateBlobCommand(string[] inputParams)
        {
            string blobName = inputParams[1];
            int health = int.Parse(inputParams[2]);
            int damage = int.Parse(inputParams[3]);
            var behavior = this.behaviorFactory.CreateBehavior(inputParams[4], this.userInterface);
            var attackType = this.attackFactory.CreateAttack(inputParams[5]);

            var blob = this.blobFactory.Create(blobName, damage, health, behavior, attackType, this.printEvents, this.userInterface);

            this.database.AddBlob(blob);
        }
    }
}