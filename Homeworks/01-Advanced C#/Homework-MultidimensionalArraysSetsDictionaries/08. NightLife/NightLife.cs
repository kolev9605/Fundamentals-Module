using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

class NightLife
{
    private static void Main()
    {
        Dictionary<string, Dictionary<string, SortedSet<string>>> venues = new Dictionary<string, Dictionary<string, SortedSet<string>>>();
        string command = Console.ReadLine();
        //city;venue;performer
        while (command != "END")
        {
            string[] commandParts = command.Split(';');
            string city = commandParts[0];
            string venue = commandParts[1];
            string performer = commandParts[2];
            if (!venues.ContainsKey(city))
            {
                venues.Add(city, new Dictionary<string, SortedSet<string>>());
            }
            if (!venues[city].ContainsKey(venue))
            {
                venues[city].Add(venue, new SortedSet<string>());
            }
            venues[city][venue].Add(performer);
            command = Console.ReadLine();
        }
        foreach (var pair in venues)
        {
            Console.WriteLine(pair.Key);
            foreach (var innerPair in pair.Value.OrderBy(c=>c.Key))
            {
                Console.WriteLine("->{0}: {1}", innerPair.Key, String.Join(", ", innerPair.Value));
            }
        }
    }
}
