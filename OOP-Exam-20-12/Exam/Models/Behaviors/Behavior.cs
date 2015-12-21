namespace Exam.Models.Behaviors
{
    using Interface;
    public abstract class Behavior : IBehavior
    {
        protected Behavior(string name, IUserInterface userInterface)
        {
            this.Name = name;
            this.HasTriggered = false;
            this.UserInterface = userInterface;
        }

        public string Name { get; }
        public bool HasTriggered { get; set; }
        public IUserInterface UserInterface { get; set; }

        public abstract void Trigger(IBlob blob);
        public abstract void ToggledEffect(IBlob blob);
    }
}
