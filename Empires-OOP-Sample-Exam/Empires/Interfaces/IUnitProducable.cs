namespace Empires.Interfaces
{
    public interface IUnitProducable
    {
        bool CanProduceUnit { get; }

        IUnit ProduceUnit();
    }
}
