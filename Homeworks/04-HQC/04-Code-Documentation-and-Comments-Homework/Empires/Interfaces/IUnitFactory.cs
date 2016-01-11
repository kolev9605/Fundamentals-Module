namespace Empires.Interfaces
{
    /// <summary>
    /// Creates a object of IUnit Type
    /// </summary>
    public interface IUnitFactory
    {
        IUnit CreateUnit(string unitType);
    }
}
