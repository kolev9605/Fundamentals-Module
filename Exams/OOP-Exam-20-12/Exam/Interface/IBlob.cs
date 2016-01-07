namespace Exam.Interface
{
    public interface IBlob : IAttackable, IKillable, IUpdatable
    {
        string Name { get; set; }
        IBehavior Behavior { get; set; }
        IAttack AttackType { get; set; }
        void TriggerBehavior();
        void TriggerToggledEffect();
    }
}
