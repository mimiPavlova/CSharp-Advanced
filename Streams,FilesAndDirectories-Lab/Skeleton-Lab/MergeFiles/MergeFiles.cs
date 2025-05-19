namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using(StreamReader reader=new StreamReader(firstInputFilePath))
            {
                using (StreamReader secindReader=new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter writer=new StreamWriter(outputFilePath))
                    {
                        while (!reader.EndOfStream||!secindReader.EndOfStream)
                        {
                            writer.WriteLine(reader.ReadLine());
                            writer.WriteLine(secindReader.ReadLine());
                        }
                    }
                }
            }

        }
    }
}
