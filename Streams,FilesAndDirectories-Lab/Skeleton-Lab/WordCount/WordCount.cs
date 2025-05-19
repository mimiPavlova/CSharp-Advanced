namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int>occurencesMap=new Dictionary<string, int>();
            using (StreamReader reader1=new StreamReader(wordsFilePath))
            {
                while (!reader1.EndOfStream)
                {
                    string[] words = reader1.ReadLine().ToLower().Split(" ");
                    foreach (var item in words)occurencesMap.Add(item.Trim(), 0);
                    
                }
            }
            using (StreamReader reader = new StreamReader(textFilePath))
            {
                while (!reader.EndOfStream)
                {
                    string[] words = reader.ReadLine().ToLower().Split(new char[] { ' ', ',', '.', '!', '?', '-', ':', ';' });
                    foreach (var item in words)
                    {
                        if (occurencesMap.ContainsKey(item))
                        {
                            occurencesMap[item]++;
                        }
                    }
                }
            }
            using (StreamWriter writer=new StreamWriter(outputFilePath))
            {
                foreach (var item in occurencesMap.OrderByDescending(w=>w.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }

        }
    }
}
