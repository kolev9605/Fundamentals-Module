namespace Empires.Core.Factories
{
    using System;
    using Entities.Buildings;
    using Interfaces;

    public class BuildingFactory : IBuildingFactory
    {
        public IBuilding CreateBuilding(string buildingType, IUnitFactory unitFactory, IResourceFactory resourceFactory)
        {
            switch (buildingType)
            {
                case "barracks":
                    return new Barracks(unitFactory, resourceFactory);
                case "archery":
                    return new Archery(unitFactory, resourceFactory);
                default:
                    throw new ArgumentException("Not supported building");
            }
        }
    }
}