namespace Empires.Entities.Buildings
{
    using Enums;
    using Interfaces;

    public class Barracks : Building
    {
        private const string UnitType = "Swordsman";
        private const int UnitProduceTime = 4;
        private const int resourceQuantity = 10;
        private const ResourceType ResourceType = Enums.ResourceType.Steel;
        private const int ResourceProduceTime = 3;

        public Barracks(IUnitFactory unitFactory, IResourceFactory resourceFactory)
            : base(ResourceType, ResourceProduceTime, resourceQuantity, UnitType, UnitProduceTime, unitFactory, resourceFactory)
        {
        }
    }
}
