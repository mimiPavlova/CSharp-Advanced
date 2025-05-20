namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            //If zipFile with this nsme exist=delete it
            if(File.Exists(zipArchiveFilePath)) {File.Delete(zipArchiveFilePath); }
            //Using ZipArchive to create zipFile:
            //1. Get name if the input lile
            //2. Create archive
            using (ZipArchive archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create))
            {
                string name=Path.GetFileName(inputFilePath);
                archive.CreateEntryFromFile(inputFilePath, name); 
            }
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            //Open zipArchive, to read zip file
            using (ZipArchive archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Read))
            {
                //Get element from the archive with the same name, if it doesn't exist, thow exception
                ZipArchiveEntry entry = archive.GetEntry(fileName);
                if (entry is null)
                {
                    throw new InvalidOperationException("Invalide file name provided!");

                }
                //Extract the zip file to the output file
                entry.ExtractToFile(outputFilePath);
            }
        }
    }
}
