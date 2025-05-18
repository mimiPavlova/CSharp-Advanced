
int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int r = data[0], c=data[1];
int[,]matrix=new int[r,c];
for (int i = 0; i < r; i++)
{
    int[] arr = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
	for (int j = 0; j < c; j++)
	{
		matrix[i, j]=arr[j];
	}
}

int sum = 0, maxSumRow = 0, maxSumCol = 0;

for (int i = 0; i < r-2; i++)
{
	for (int j = 0; j < c-2; j++)
	{
	int currentSum = matrix[i, j]+matrix[i, j+1]+matrix[i, j+2]
			+matrix[i+1, j]+matrix[i+1, j+1]+matrix[i+1, j+2]
			+matrix[i+2, j]+matrix[i+2, j+1]+matrix[i+2, j+2];

		if (currentSum>sum)
		{
			sum=currentSum;
			maxSumRow=i;
			maxSumCol=j;
		}
	}
	
}

Console.WriteLine($"Sum = {sum}");
Console.WriteLine($"{matrix[maxSumRow, maxSumCol]} {matrix[maxSumRow, maxSumCol+1]} {matrix[maxSumRow, maxSumCol+2]}");
Console.WriteLine($"{matrix[maxSumRow+1, maxSumCol]} {matrix[maxSumRow+1, maxSumCol+1]} {matrix[maxSumRow+1, maxSumCol+2]}");
Console.WriteLine($"{matrix[maxSumRow+2, maxSumCol]} {matrix[maxSumRow+2, maxSumCol+1]} {matrix[maxSumRow + 2, maxSumCol+2]}");