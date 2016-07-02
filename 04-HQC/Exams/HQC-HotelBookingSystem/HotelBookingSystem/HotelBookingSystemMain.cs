namespace HotelBookingSystem
{
    using Core;
    using Core.IO;
    using Data;
    using Interfaces;

    public class HotelBookingSystemMain
    {
        public static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            IHotelBookingSystemData database = new HotelBookingSystemData();
            IInputReader reader = new ConsoleReader();
            IOutputWriter writer = new ConsoleWriter();

            var engine = new Engine(database, reader, writer);
            engine.StartOperation();
        }
    }
}
