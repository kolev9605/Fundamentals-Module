using System;

namespace Empires.Core
{
    using System.Linq;
    using System.Text;
    using Interfaces;

    class Engine : IEngine
    {
        private IUnitFactory unitFactory;
        private IResourceFactory resourceFactory;
        private IBuildingFactory buildingFactory;
        private IInputReader reader;
        private IOutputWriter writer;
        private IEmpiresData data;

        public Engine(IUnitFactory unitFactory, IResourceFactory resourceFactory,IBuildingFactory buildingFactory, IInputReader reader, IOutputWriter writer, IEmpiresData data)
        {
            this.unitFactory = unitFactory;
            this.resourceFactory = resourceFactory;
            this.buildingFactory = buildingFactory;
            this.reader = reader;
            this.writer = writer;
            this.data = data;
        }

        public void Run()
        {
            while (true)
            {
                string[] inputParams = this.reader.Read().Split(' ');
                ExecuteCommand(inputParams);
                UpdateBuildings();
            }
        }

        private void UpdateBuildings()
        {
            foreach (var building in this.data.Buildings)
            {
                if (building.CanProduceResource)
                {
                    var resource = building.ProduceResource();
                    this.data.AddResource(resource,resource.Quantity);
                    //this.data.Resources[resource.ResourceType] += resource.Quantity;
                }
                if (building.CanProduceUnit)
                {
                    var unit = building.ProduceUnit();
                    this.data.AddUnit(unit);
                }
                building.Update();
            }
        }

        private void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "build":
                    ExecuteBuildCommand(inputParams);
                    break;
                case "skip":
                    break;
                case "empire-status":
                    ExecuteEmpireStatusCommand(inputParams);
                    break;
                case "armistice":
                    Environment.Exit(0);
                    break;
                default:
                    throw new InvalidOperationException("Unsupplied command");
            }
        }

        private void ExecuteEmpireStatusCommand(string[] inputParams)
        {
            var builder = new StringBuilder();

            builder.AppendLine("Treasury:");
            foreach (var resource in this.data.Resources)
            {
                int quantity = resource.Value;
                builder.AppendFormat("--{0}: {1}\n", resource.Key, quantity);
            }
            builder.AppendLine("Buildings:");
            if (this.data.Buildings.Any())
            {
                foreach (var building in this.data.Buildings)
                {
                    builder.AppendLine(building.ToString());
                }
            }
            else
            {
                builder.AppendLine("N/A");
            }

            builder.AppendLine("Units:");
            if (this.data.Units.Any())
            {
                foreach (var unit in this.data.Units)
                {
                    builder.AppendFormat("--{0}: {1}\n", unit.Key, unit.Value);
                }
            }
            else
            {
                builder.AppendLine("N/A");
            }

            this.writer.Write(builder.ToString().Trim());

        }

        private void ExecuteBuildCommand(string[] inputParams)
        {
            string buildingType = inputParams[1];
            var building = this.buildingFactory.CreateBuilding(buildingType, this.unitFactory, this.resourceFactory);
            this.data.AddBuilding(building);
        }
    }
}
