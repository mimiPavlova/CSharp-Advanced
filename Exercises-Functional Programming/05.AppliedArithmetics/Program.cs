using System.Collections.Generic;
using System.Linq;
using System;

namespace _05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[]numbers=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            Dictionary<string, Action<int[]>> actionsByCommand = new Dictionary<string, Action<int[]>>
            {
                ["add"]= arr=>Transform(arr,n=>n+1 ),
                ["multiply"]=arr=>Transform(arr,n=>n*2),
                ["subtract"]=arr=>Transform(arr,n=>n-1),
               ["print"]=arr => Console.WriteLine(string.Join(" ", arr))
            };




           
            string command;
            while((command = Console.ReadLine()) != "end")
            {
                if(actionsByCommand.ContainsKey(command))
                {
                    Action<int[]>action = actionsByCommand[command];
                    action(numbers);
                }
            }
        }
        static void Transform(int[]numbers, Func<int, int> changeFunk)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]=changeFunk(numbers[i]);
            }
        }
    }
}
