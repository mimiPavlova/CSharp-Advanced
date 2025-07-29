using System.Data;

namespace _02.DeliveryBoy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]dementions=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
          int r=dementions[0];
          int c=dementions[1];

            char[,]matrix=new char[r,c];
            for (int i = 0; i < r; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j]=input[j];
                }
            }

            (int startRow, int startCol)=FindStartingPossition(matrix);
            int currentRow=startRow, currentCol=startCol;
            bool addressIsReached = false, positionOutOfMaps = false;

            while (!addressIsReached&&!positionOutOfMaps)
            {
                string command = Console.ReadLine();
                int nextRow=currentRow, nextCol=currentCol;
                if (command=="up") nextRow--;
                else if (command=="down") nextRow++;
                else if (command=="left") nextCol--;
                else if (command=="right") nextCol++;

                if (nextRow<0||nextRow>=r||nextCol<0||nextCol>=c)
                {
                    positionOutOfMaps= true;
                }
                else
                {
                    if (matrix[nextRow, nextCol]=='-')
                        matrix[nextRow, nextCol]='.';
                    else if (matrix[nextRow, nextCol]=='P')
                    {
                        matrix[nextRow, nextCol]='R';
                        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                    }
                    else if (matrix[nextRow, nextCol]=='A')
                    {
                        matrix[nextRow, nextCol]='P';
                        addressIsReached = true;
                    }
                   
                    if (positionOutOfMaps|| matrix[nextRow, nextCol]!='*')
                    {
                        currentRow=nextRow;
                        currentCol=nextCol;
                    }

                }
            

            }
            if(addressIsReached)
            {
                Console.WriteLine("Pizza is delivered on time! Next order...");

            }
            else if (positionOutOfMaps)
            {
                matrix[startRow, startCol] =' ';
                Console.WriteLine("The delivery is late. Order is canceled.");
            }
            PrintMatrix(matrix);
        }
        private static (int row, int col) FindStartingPossition(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j <matrix.GetLength(1); j++)
                {
                    if (matrix[i, j]=='B')
                    {
                        return (i, j);
                    }
                }
            }
            throw new Exception("NotFound");
        }
        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
