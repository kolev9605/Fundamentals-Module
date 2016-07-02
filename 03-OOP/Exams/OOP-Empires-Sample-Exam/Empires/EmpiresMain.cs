namespace Empires
{
    using Core;
    using Core.Factories;
    using Interfaces;
    using IO;

    public class EmpiresMain
    {
        public static void Main(string[] args)
        {
            IBuildingFactory buildingFactory = new BuildingFactory();
            IUnitFactory unitFactory = new UnitFactory();
            IResourceFactory resourceFactory = new ResourceFactory();
            IInputReader reader = new ConsoleReader();
            IOutputWriter writer = new ConsoleWriter();
            IEmpiresData database = new Database();

            IEngine engine = new Engine(unitFactory, resourceFactory, buildingFactory, reader, writer, database);
            engine.Run();
        }
    }
}