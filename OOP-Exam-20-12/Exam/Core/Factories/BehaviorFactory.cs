namespace Exam.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Exceptions;
    using Interface;
    using Models.Behaviors;

    public class BehaviorFactory : IBehaviorFactory
    {
        public IBehavior CreateBehavior(string behaviorName, IUserInterface userInterface)
        {
            switch (behaviorName)
            {
                case "Inflated":
                    return new InflatedBehavior(userInterface);
                case "Aggressive":
                    return new AggressiveBehavior(userInterface);
                default:
                    throw new FactoryException(Messeges.NotSupportedBehavior);
            }
        }
    }
}
