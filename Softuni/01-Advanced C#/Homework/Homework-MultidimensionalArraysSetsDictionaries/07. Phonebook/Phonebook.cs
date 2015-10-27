using System;
using System.Collections.Generic;
using System.Linq;

internal class Phonebook
{
    private static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string[] command = Console.ReadLine().Split('-');
        while (command[0] != "search")
        {
            phonebook.Add(command[0], command[1]);
            command = Console.ReadLine().Split('-');
        }
        bool isFound = false;
        string searchValue = Console.ReadLine();
        string keyKeeper = "";
        string valueKeeper = "";
        while (true)
        {
            foreach (var contact in phonebook)
            {
                if (searchValue == contact.Key)
                {
                    isFound = true;
                    keyKeeper = contact.Key;
                    valueKeeper = contact.Value;
                }
                else
                {
                    continue;
                }
            }
            if (isFound == true)
            {
                Console.WriteLine("{0} -> {1}", keyKeeper, valueKeeper);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", searchValue);
            }
            isFound = false;
            searchValue = Console.ReadLine();

        }
    }
}

