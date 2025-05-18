int n=int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
	for (int j = 0; j < n; j++)
	{
		matrix[i, j]=data[j];
	}
}

int primaryDiagonalSum = 0;
int secondaryDiagonalSum = 0;
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		if (i==j)
		{
			primaryDiagonalSum+= matrix[i, j];
		}
		if (i+j==n-1)
		{
			secondaryDiagonalSum+= matrix[i, j];
		}
	}
}


Console.WriteLine(Math.Abs(primaryDiagonalSum-secondaryDiagonalSum));