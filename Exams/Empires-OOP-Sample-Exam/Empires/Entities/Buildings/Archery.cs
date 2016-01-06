namespace Empires.Entities.Buildings
{
    using Enums;
    using Interfaces;

    class Archery : Building
    {
        private const string UnitType = "Archer";
        private const int UnitProduceTime = 3;
        private const int resourceQuantity = 5;
        private const ResourceType ResourceType = Enums.ResourceType.Gold;
        private const int ResourceProduceTime = 2;

        public Archery(IUnitFactory unitFactory, IResourceFactory resourceFactory)
            : base(ResourceType, ResourceProduceTime, resourceQuantity, UnitType, UnitProduceTime, unitFactory, resourceFactory)
        {
        }
    }
}
