namespace OddLines;

using System.IO;
	
public class OddLines
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\Files\input.txt";
        string outputFilePath = @"..\..\..\Files\output.txt";

        ExtractOddLines(inputFilePath, outputFilePath);
    }

    public static void ExtractOddLines(string inputFilePath, string outputFilePath)
    {
        using (StreamReader reader = new StreamReader(inputFilePath))
        { 
           using(StreamWriter writer= new StreamWriter(outputFilePath))
            {
                int n = 0;
                while (!reader.EndOfStream)
                {
                    string text=reader.ReadLine();
                    if (n%2!=0) writer.WriteLine(text);
                    n++;
                }
            }
        }
    }
}
