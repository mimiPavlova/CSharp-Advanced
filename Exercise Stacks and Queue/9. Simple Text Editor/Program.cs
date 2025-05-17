using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder text = new StringBuilder();
        Stack<string> history = new Stack<string>();

        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split(" ");
            int command = int.Parse(data[0]);

            switch (command)
            {
                case 1: 
                    history.Push(text.ToString());
                    text.Append(data[1]);
                    break;

                case 2: 
                    history.Push(text.ToString());
                    int count = int.Parse(data[1]);
                    if (count <= text.Length)
                        text.Remove(text.Length - count, count);
                    else
                        text.Clear(); 
                    break;

                case 3:
                    int index = int.Parse(data[1]) - 1;
                    if (index >= 0 && index < text.Length)
                        Console.WriteLine(text[index]);
                    break;

                case 4: 
                    if (history.Count > 0)
                    {
                        text.Clear();
                        text.Append(history.Pop());
                    }
                    break;
            }
        }
    }
}
