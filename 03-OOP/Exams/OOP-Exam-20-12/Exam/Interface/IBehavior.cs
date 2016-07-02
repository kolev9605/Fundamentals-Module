namespace Exam.Interface
{
    public interface IBehavior
    {
        string Name { get; }
        bool HasTriggered { get; set; }
        void Trigger(IBlob blob);
        void ToggledEffect(IBlob blob);
    }
}
