namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader=new StreamReader(inputFilePath))
            {
                using (StreamWriter writer=new StreamWriter(outputFilePath))
                {

                    int n = 0;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        int letters = 0, punctuations = 0;

                        foreach (char simbol in line)
                        {
                            if (char.IsLetter(simbol)) letters++;
                            if (char.IsPunctuation(simbol)) punctuations++;
                        }

                        writer.WriteLine($"Line {++n}: {line} ({letters})({punctuations})");
                    }                    

                    
                }
            }

               

            
            
        }
    }
}
