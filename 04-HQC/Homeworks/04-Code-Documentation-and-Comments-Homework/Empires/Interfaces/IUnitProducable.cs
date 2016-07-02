namespace Empires.Interfaces
{
    /// <summary>
    /// Indicates that the building can produce units
    /// </summary>
    public interface IUnitProducable
    {
        bool CanProduceUnit { get; }

        IUnit ProduceUnit();
    }
}
