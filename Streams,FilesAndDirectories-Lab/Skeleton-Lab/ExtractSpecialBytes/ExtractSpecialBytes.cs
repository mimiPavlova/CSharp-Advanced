namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {

            HashSet <byte>specialBytes=new HashSet<byte>();
            using (StreamReader reader = new StreamReader(bytesFilePath))
            {
                while (!reader.EndOfStream)
                {

                    specialBytes.Add(byte.Parse(reader.ReadLine()));
                }
            }

            using FileStream fileReader= new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read);
            using FileStream witer=new FileStream(outputPath, FileMode.Create, FileAccess.Write) ;
            byte[] buffer = new byte[1024];
            int bytesRead;

            while ((bytesRead=fileReader.Read(buffer))!=0)
            {
                int outputBytes = 0;
                for (int i = 0; i < bytesRead; i++)
                {
                    if (specialBytes.Contains(buffer[i]))
                    {
                        buffer[outputBytes++]=buffer[i];
                    }
                }
                witer.Write(buffer, 0, outputBytes);
            }
        }
    }
}
