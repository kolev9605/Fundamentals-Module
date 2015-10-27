using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

internal class Unleashed
{
    private static void Main()
    {
        string command = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        while (command != "End")
        {
            sb.Append(command + "\n");
            command = Console.ReadLine();
        }
        string pattern = @"(.+)\s@(.+)\s(\d+)\s(\d+)";
        MatchCollection matches = Regex.Matches(sb.ToString(), pattern);

        Dictionary<string, Dictionary<string, int>> venuesData = new Dictionary<string, Dictionary<string, int>>();
        foreach (Match match in matches)
        {
            string venue = match.Groups[2].Value;
            string singer = match.Groups[1].Value;
            int ticketsPrice = int.Parse(match.Groups[3].Value);
            int ticketsCount = int.Parse(match.Groups[4].Value);
            int totalPrice = ticketsCount*ticketsPrice;

            if (!venuesData.ContainsKey(venue))
            {
                venuesData.Add(venue,new Dictionary<string, int>());
            }
            if (!venuesData[venue].ContainsKey(singer))
            {
                venuesData[venue].Add(singer,totalPrice);
            }
            else
            {
                venuesData[venue][singer] += totalPrice;
            }
        }

        foreach (var pair in venuesData)
        {
            Console.WriteLine(pair.Key);
            foreach (var innerPair in pair.Value.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine("#  {0} -> {1}",innerPair.Key,innerPair.Value);
            }
        }
    }
}