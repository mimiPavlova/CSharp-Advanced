
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
int diagonalSum = 0;
for (int i = 0; i < n; i++)
{
    int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
	for (int j = 0; j < n; j++)
	{
		matrix[i, j]=data[j];
		if (i==j) diagonalSum+=data[j];
	}
}
Console.WriteLine(diagonalSum);