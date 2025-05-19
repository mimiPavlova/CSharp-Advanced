namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
           using FileStream reader=new FileStream(inputFilePath, FileMode.Open, FileAccess.Read);
            using FileStream writer=new FileStream(outputFilePath, FileMode.Create, FileAccess.Write);
            byte[] buffer= new byte[1024];
            int readBytes = 0;
            while ((readBytes=reader.Read(buffer))!=0)
            {
                writer.Write(buffer, 0, readBytes);
            }

        }
    }
}
