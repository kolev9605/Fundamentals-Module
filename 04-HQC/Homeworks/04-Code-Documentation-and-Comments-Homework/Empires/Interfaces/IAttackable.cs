namespace Empires.Interfaces
{
    /// <summary>
    /// Indicates that the unit can be attacked
    /// </summary>
    public interface IAttackable
    {
        int Damage { get; }
    }
}
