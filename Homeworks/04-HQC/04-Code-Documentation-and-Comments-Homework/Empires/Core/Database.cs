namespace Empires.Core
{
    using System;
    using System.Collections.Generic;
    using Enums;
    using Interfaces;

    class Database : IEmpiresData
    {
        //fields

        //Can it be done with properties only? where i need fields? Why?
        private readonly IDictionary<string, int> units;
        private readonly IDictionary<ResourceType, int> resources;
        private IList<IBuilding> buildings = new List<IBuilding>();

        //ctor
        public Database()
        {
            //should I inint in the ctor? 
            this.resources = new Dictionary<ResourceType, int>();
            this.units = new Dictionary<string, int>();
            InitResources();
        }

        //props
        public IDictionary<ResourceType, int> Resources
        {
            get { return this.resources; }
        }

        public IEnumerable<IBuilding> Buildings
        {
            get { return this.buildings; }
        }

        public IDictionary<string, int> Units
        {
            get { return this.units; }
        }
        

        //methonds
        public void AddUnit(IUnit unit)
        {
            string unitType = unit.GetType().Name;

            if (!this.units.ContainsKey(unitType))
            {
                this.units[unitType] = 0;
            }
            this.units[unitType] += 1;
        }

        public void AddBuilding(IBuilding building)
        {
            this.buildings.Add(building);
        }

        public void AddResource(IResource resource, int quantity)
        {
            ResourceType resourceType = resource.ResourceType;
            this.resources[resourceType] += quantity;
        }

        private void InitResources()
        {
            this.resources[ResourceType.Gold] = 0;
            this.resources[ResourceType.Steel] = 0;
        }
    }
}
