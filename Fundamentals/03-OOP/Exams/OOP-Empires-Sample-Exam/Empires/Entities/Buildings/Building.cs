namespace Empires.Entities.Buildings
{
    using System;
    using Enums;
    using Interfaces;

    public abstract class Building : IBuilding
    {
        private int tunrsPassed = 0;

        private ResourceType resourceType;
        private int resourceProduceTime;

        private string unitType;
        private int unitProduceTime;

        private IUnitFactory unitFactory;
        private IResourceFactory resourceFactory;

        private const int productionDelay = 1;

        protected Building
            (ResourceType resourceType,
            int resourceProduceTime,
            int resourceQuantity,
            string unitType,
            int unitProduceTime,
            IUnitFactory unitFactory,
            IResourceFactory resourceFactory)
        {
            this.resourceType = resourceType;
            this.resourceProduceTime = resourceProduceTime;
            this.Quantity = resourceQuantity;
            this.unitType = unitType;
            this.unitProduceTime = unitProduceTime;
            this.unitFactory = unitFactory;
            this.resourceFactory = resourceFactory;
        }

        public int Quantity { get; }

        public bool CanProduceResource
        {
            get { return (this.tunrsPassed) % this.resourceProduceTime == 0 && this.tunrsPassed > 0; }
        }

        public bool CanProduceUnit
        {
            get { return (this.tunrsPassed) % this.unitProduceTime == 0 && this.tunrsPassed > 0; }
        }

        public IUnit ProduceUnit()
        {
            return this.unitFactory.CreateUnit(this.unitType);
        }

        public IResource ProduceResource()
        {
            return this.resourceFactory.CreateResource(this.resourceType, this.Quantity);
        }

        public void Update()
        {
            this.tunrsPassed++;
        }

        public override string ToString()
        {
            //--Archery: 4 turns (2 turns until Archer, 2 turns until Gold)
            return string.Format("--{0}: {1} turns ({2} turns until {3}, {4} turns until {5})",
                this.GetType().Name,
                this.tunrsPassed - productionDelay,
                this.unitProduceTime- ((this.tunrsPassed-productionDelay) % this.unitProduceTime),
                this.unitType,
                this.resourceProduceTime - ((this.tunrsPassed-productionDelay) % this.resourceProduceTime),
                this.resourceType
                );

        }
    }
}
