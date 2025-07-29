using System.Diagnostics.SymbolStore;

namespace _02;

internal class Program
{
    static void Main(string[] args)
    {
        int[] dementions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        char[,] matrix = new char[dementions[0], dementions[1]];
        int x = 0, y = 0;
        for (int i = 0; i < dementions[0]; i++)
        {
            string data = Console.ReadLine();
            for (int j = 0; j < dementions[1]; j++)
            {

                matrix[i, j]=data![j];
                if (matrix[i, j]=='C')
                {
                    x=i; y=j;
                    
                }

            }
        }
        int seconds = 16;
       char[,] startMatrix = ((char[,])matrix.Clone());
        while (seconds>0)
        {
            string command = Console.ReadLine();

            if(!ValidateCommand(matrix, x, y, command))
            {
                seconds--;
                continue;
            }

            switch (command)
            {
                case "up":
                    x--;
                    break;
                case "down":
                    x++;
                    break;
                case "right":
                    y++;
                    break;
                case "left":
                    y--;
                    break;
                case "defuse":

                    if (matrix[x, y] !='B')
                    {
                        seconds-=2; continue;
                    }
                    else if (matrix[x, y]=='B')
                    {
                        seconds-=4;
                        if (seconds>=0)
                        {
                            matrix[x, y]='D';
                            Console.WriteLine("Counter-terrorist wins!");
                            Console.WriteLine($"Bomb has been defused: {seconds} second/s remaining.");
                            PrintMatrix(matrix);
                            return;
                        }
                        else
                        {

                            matrix[x, y]='X';
                            Console.WriteLine("Terrorists win!");
                            Console.WriteLine("Bomb was not defused successfully!");
                            Console.WriteLine($"Time needed: {Math.Abs(seconds)} second/s.");
                            PrintMatrix(matrix);
                            return;
                        }
                    }
                    break;
            }
            if (matrix[x, y] == 'T')
            { 
                matrix[x, y]='*';
                Console.WriteLine("Terrorists win!");
                PrintMatrix(matrix);
                return;
            }
            seconds--;

        }

        
            Console.WriteLine("Terrorists win!");
            Console.WriteLine("Bomb was not defused successfully!");
            Console.WriteLine($"Time needed: {Math.Abs(seconds)} second/s.");
            PrintMatrix(startMatrix);

    }


    static void PrintMatrix<T>(T[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    static bool ValidateCommand(char[,] matrix, int x, int y, string command)
    {
        switch (command)
        {
            case "up":
                x--;
                break;
            case "down":
                x++;
                break;
            case "right":
                y++;
                break;
            case "left":
                y--;
                break;
        }
        return x<matrix.GetLength(0)&&y<matrix.GetLength(1)&&x>=0&&y>=0;
    }


}