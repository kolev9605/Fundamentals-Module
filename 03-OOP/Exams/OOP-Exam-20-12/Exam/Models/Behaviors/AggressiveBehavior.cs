namespace Exam.Models.Behaviors
{
    using Interface;

    class AggressiveBehavior : Behavior
    {
        private const string BehaviorType = "Aggressive";

        public AggressiveBehavior(IUserInterface userInterface) 
            : base(BehaviorType, userInterface)
        {
            this.UserInterface = userInterface;
        }

        public override void Trigger(IBlob blob)
        {
            if (!this.HasTriggered)
            {
                this.HasTriggered = true;
                blob.Damage *= 2;
            }
        }

        public override void ToggledEffect(IBlob blob)
        {
            if (this.HasTriggered)
            {
                blob.Damage -= 5;
                if (blob.Damage < blob.InitialDamage)
                {
                    blob.Damage = blob.InitialDamage;
                }
            }
        }
    }
}
