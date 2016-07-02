namespace Empires.Interfaces
{
    /// <summary>
    /// Creates a object of IBuilding type
    /// </summary>
    public interface IBuildingFactory
    {
        IBuilding CreateBuilding(string buildingType, IUnitFactory unitFactory, IResourceFactory resourceFactory);
    }
}
