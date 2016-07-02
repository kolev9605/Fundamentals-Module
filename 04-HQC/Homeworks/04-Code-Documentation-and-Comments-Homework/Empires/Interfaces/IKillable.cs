namespace Empires.Interfaces
{
    /// <summary>
    /// Indicates that the unit can be killed
    /// </summary>
    public interface IKillable
    {
        int Health { get; }
    }
}
