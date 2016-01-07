namespace Exam.Models.Behaviors
{
    using Interface;

    public class InflatedBehavior : Behavior
    {
        private const string BehaviorType = "Inflated";

        public InflatedBehavior(IUserInterface userInterface)
            : base(BehaviorType, userInterface)
        {
            this.UserInterface = userInterface;
        }

        public override void Trigger(IBlob blob)
        {
            if (!this.HasTriggered)
            {
                this.HasTriggered = true;
                blob.Health += 50;
            }
        }

        public override void ToggledEffect(IBlob blob)
        {
            if (this.HasTriggered)
            {
                blob.Health -= 10;
            }
        }
    }
}
