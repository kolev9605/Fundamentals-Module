using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordCount
{
    static void Main()
    {
        var wordsReader = new StreamReader("../../words.txt");
        var textReader = new StreamReader("../../text.txt");
        var writer = new StreamWriter("../../result.txt");
        using (wordsReader)
        {
            using (textReader)
            {
                using (writer)
                {
                    string word = wordsReader.ReadLine();
                    List<List<string>> wordList = new List<List<string>>();

                    while (word != null) //reading the words
                    {
                        wordList.Add(new List<string> { word });
                        word = wordsReader.ReadLine();
                    }

                    //reading the first line of the text
                    string[] lineOfTextToArray = textReader.ReadLine() //splitting
                        .ToLower()
                        .Split(new char[] { ' ', ',', '.', '?', '!', '-' }, StringSplitOptions
                        .RemoveEmptyEntries);

                    for (int i = 0; i < wordList.Count; i++)
                    {
                        for (int j = 0; j < lineOfTextToArray.Length; j++)
                        {
                            if (wordList[i].Contains(lineOfTextToArray[j]))
                            {
                                wordList[i].Add(lineOfTextToArray[j]);
                            }
                        }
                        try
                        {
                            lineOfTextToArray = textReader.ReadLine()
                                .ToLower()
                                .Split(new string[] { " ", ",", "\\.+", "\\?+", "!", "-", "…" }, StringSplitOptions
                                .RemoveEmptyEntries);
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }
                    
                    for (int i = 0; i < wordList.Count; i++) //The program doest not sort the output.
                    {
                        writer.Write(wordList[i].Last() + " - " + wordList[i].Count + Environment.NewLine);
                    }

                }
            }
        }
    }
}