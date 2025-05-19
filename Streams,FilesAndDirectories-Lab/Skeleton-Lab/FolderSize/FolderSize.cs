namespace FolderSize
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
           Queue <string>q=new Queue<string>();
            q.Enqueue(folderPath);
            long tottalSize = 0;
            while (q.Count>0)
            {
                string currentFolder = q.Dequeue();
                string[]files=Directory.GetFiles(currentFolder);
                foreach (string filePath in files)
                {
                    FileInfo fileInfo=new FileInfo(filePath);
                    tottalSize+= fileInfo.Length;
                }
                string[]subFolders = Directory.GetDirectories(currentFolder);
                foreach (string subfolderPath in subFolders)
                {
                    q.Enqueue(subfolderPath);
                }
            }

            using (StreamWriter outputWriter = new StreamWriter(outputFilePath))
            {
                outputWriter.WriteLine($"{tottalSize/1024.0} KB");
            }
        }
    }
}
