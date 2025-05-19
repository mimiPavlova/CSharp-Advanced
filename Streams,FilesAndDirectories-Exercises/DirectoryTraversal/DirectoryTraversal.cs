using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            Dictionary<string, List<FileInfo>>FilesByExtentions=new Dictionary<string, List<FileInfo>>();
            StringBuilder sb = new StringBuilder();
            string[]files=Directory.GetFiles(inputFolderPath);
            foreach (string fileName in files)
            {
                FileInfo info=new FileInfo(fileName);

                if (!FilesByExtentions.ContainsKey(info.Extension))
                {
                    FilesByExtentions.Add(info.Extension, new List<FileInfo>());

                }
                FilesByExtentions[info.Extension].Add(info);
                   
            }

            foreach (var(extention, fileInfos) in FilesByExtentions.OrderByDescending(n=>n.Value.Count).
                ThenBy(n=>n.Key))
            {
                sb.AppendLine(extention);
                foreach (FileInfo info  in fileInfos.OrderBy(x=>x.Length))
                {
                    sb.AppendLine($"--{info.Name} - {info.Length/1024m}");
                }
            }
            //Console.WriteLine(sb.ToString());
            return sb.ToString().Trim();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string pathToDesktop = Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop);
            //string pathToOutput=Path.Combine(pathToDesktop,reportFileName);
            string pathToOutput = pathToDesktop+reportFileName;
            File.WriteAllText(pathToOutput, textContent);
        }
    }
}
/*Write a program that traverses a given directory for 
    all files with the given extension. Search through the first 
    level of the directory only. Write information about each found 
    file in a text file named report.txt and it should be saved on the 
    Desktop. The files should be grouped by their extension. Extensions 
    should be ordered by the count of their files descending, then by name 
    alphabetically. Files under an extension should be ordered by their size. 
    report.txt should be saved on the Desktop. Ensure the desktop path is always valid, regardless of the user.*/

