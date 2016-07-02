using System.Collections.Generic;

namespace _03.PC_Catalog
{
    class Catalog
    {
        static void Main(string[] args)
        {
            Computer pc1 = new Computer("Toshiba b12", new Component("I5", 123), new Component("ADATA DDR3 gb", 50), new Component("EVGA gtx000", 300));
            Computer pc2 = new Computer("Lenovo asd", new Component("I7", 200), new Component("ADATA DDR3 4gb", 50), new Component("EVGA gtx950", 500));
            Computer pc3 = new Computer("LG asd", new Component("I3", 70), new Component("ADATA DDR3 8gb", 100), new Component("EVGA gtx500", 180));
            Computer pc4 = new Computer("ASUS dsa", new Component("Pentium", 40), new Component("ADATA DDR3 16gb", 200), new Component("EVGA gtx000", 300));


            List<Computer> pcList = new List<Computer> { pc1, pc2, pc3, pc4 };
            System.Console.WriteLine(string.Join(", ", pcList));
            pcList.Sort();
            System.Console.WriteLine("After sorting by price:\n");
            System.Console.WriteLine(string.Join(", ", pcList));
        }
    }
}
