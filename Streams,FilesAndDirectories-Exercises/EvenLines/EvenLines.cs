namespace EvenLines
{
    using System;
    using System.IO;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb=new StringBuilder();
            using(StreamReader reader=new StreamReader(inputFilePath))
            {
                int n = 0;
                while (!reader.EndOfStream)
                {
                    
                    string line = reader.ReadLine();
                    if (n%2==0)
                    {

                        char[] replace = { '-', ',', '.', '!','?' };
                       
                        foreach (char simbol in replace)
                        {
                            line=line.Replace(simbol, '@');
                           
                        }
                        string[] words = line.Split(' ');
                        Array.Reverse(words);
                        string result=string.Join(" ", words);
                        sb.AppendLine(result);
                    }

                    n++;

                }
                return sb.ToString();
            }
        }
    }
}
