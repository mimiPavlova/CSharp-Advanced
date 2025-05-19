namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using FileStream reader = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read);

            int firstPartLenght = (int)reader.Length/2;
            int secondPartLenght = (int)reader.Length-firstPartLenght;


            using (FileStream firstpart = new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write))
            {
                CoppyExact(reader, firstPartLenght, firstpart);
            }
            using (FileStream second = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write))
            {
                CoppyExact(reader, secondPartLenght, second);
            }



        }
        private static void CoppyExact(Stream sourse, int lenght, Stream destination)
        {
            byte[] buffer = new byte[1024];

            int tottalReadByes = 0;
            while (tottalReadByes<lenght)
            {
                int currentBytes = sourse.Read(buffer, 0, Math.Min(buffer.Length, lenght-tottalReadByes));
                destination.Write(buffer, 0, currentBytes);
                tottalReadByes+=currentBytes;
            }

        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {

            using (FileStream joined = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
            {
                using (FileStream partOne = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read)) partOne.CopyTo(joined);
                using (FileStream partTwo = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read)) partTwo.CopyTo(joined);
                   
            }



        }
    }
}