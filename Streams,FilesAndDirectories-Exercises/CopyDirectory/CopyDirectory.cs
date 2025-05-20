namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            //We have to delete the directory if it exists
            //recursive:true-delete the directory even if it's not empty, otherwise it won't be deleted
            if(Directory.Exists(outputPath)) Directory.Delete(outputPath, recursive:true);
            //for every file in the directory, without sub-directories:
            //1.F,irst get the name of the file
            //2.Combine fileName with the output directory path
            //3.Coppy the file to the destination 
            foreach (string pathToFile in Directory.GetFiles(inputPath))
            {
                string fileName=Path.GetFileName(pathToFile);
                string pathToDestinationFile=Path.Combine(outputPath, fileName);
                File.Copy(pathToFile, pathToDestinationFile);
            }
        }
    }
}
