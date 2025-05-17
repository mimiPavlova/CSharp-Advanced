using System.Data;
using System.Net.Http.Headers;

int []data=Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rols = data[0], cols = data[1];
int[,] matrix = new int[rols, cols];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] matrixData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

	for (int j = 0; j <matrix.GetLength(1); j++)
	{
		matrix[i,j]=matrixData[j];
		
	}
	
}
for (int c = 0; c < cols; c++)
{
	int sum = 0;
	for (int r = 0; r <rols; r++)
	{
		sum+=matrix[r,c];
	}
	Console.WriteLine(sum);
}