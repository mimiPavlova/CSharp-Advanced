using System.Numerics;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] matrix = new double[n][];


            for (int i = 0; i < n; i++)
            {
                double[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                matrix[i]=data;

            }
            matrix=MultiplyMatrix(matrix, n);

            ProcesCommand(matrix);

        }


        static double[][] MultiplyMatrix(double[][] matrix, int n)
        {
            for (int i = 1; i < n; i++)
            {

                if (matrix[i] == null || matrix[i - 1] == null) continue;
                double multiplier = matrix[i].Length==matrix[i-1].Length ? 2 : 0.5;

                for (int j = 0; j < matrix[i-1].Length; j++)
                {
                    matrix[i-1][j]*=multiplier;
                }
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j]*=multiplier;
                }

            }
            return matrix;

        }
        static void ProcesCommand(double[][] matrix)
        {
            string command;
            while ((command=Console.ReadLine().ToLower())!="end")
            {

                string[] data = command.Split(" ");
                if (data.Length!=4)
                { continue; }
                int row = int.Parse(data[1]);
                int col = int.Parse(data[2]);
                int value = int.Parse(data[3]);
                if (row<0||col<0||row>=matrix.Length||col>=matrix[row].Length)
                {
                    continue;
                }
                switch (data[0].ToLower())
                {
                    case "add":
                        matrix[row][col]+=value;
                        break;
                    case "subtract":
                        matrix[row][col]-=value;
                        break;

                }
            }
            for (int i = 0; i <matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

    }
}
