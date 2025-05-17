
int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rols = data[0], cols = data[1];
int[,] matrix = new int[rols, cols];

for (int i = 0; i < rols; i++)
{
	int[] arr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
	for (int j = 0; j < cols; j++)
	{
		matrix[i, j]=arr[j];
	}
}

int biggestSum = int.MinValue;
int row = 0;
int col = 0;
for (int i = 0; i <rols-1; i++)
{
	int sum = 0;
	
	for (int j = 0; j < cols-1; j++)
	{
		int s1 = matrix[i, j];
		int s2 = matrix[i, j+1];
		int s3 = matrix[i+1, j];
		int s4 = matrix[i+1, j+1];
		sum=s1+s2+s3+s4;
		if (sum >biggestSum)
		{ biggestSum=sum; row=i; col=j; }
	}
}

Console.WriteLine($"{ matrix[row, col] } {matrix[row, col+1]}");
Console.WriteLine($"{ matrix[row+1, col] } {matrix[row+1, col+1]}");
Console.WriteLine(biggestSum);

