using System;

class StringsAndObjects
{
    static void Main()
    {
        string helloString = "Hello";
        string worldString = "World!";
        object resultObject = helloString + " " + worldString;
        Console.WriteLine(resultObject);
        string resultString = (string)resultObject;
        Console.WriteLine(resultString);



    }
}

