

int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];

for (int i = 0; i < n; i++)
{
	int[] elements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
	for (int j = 0; j < n; j++)
	{
		matrix[i, j]=elements[j];
	}
}
	string command;
	while ((command=Console.ReadLine())!="END")
	{
		string[] data = command.Split(" ");
		int row = int.Parse(data[1]);
		int col = int.Parse(data[2]);
		if (row<0||col<0||row>=n||col>=n)
		{
			Console.WriteLine("Invalid coordinates"); continue;
		}
		int value = int.Parse(data[3]);
		switch (data[0].ToLowerInvariant())
		{
			case "add":
				matrix[row, col]+=value;

				break;
			case "subtract":
				matrix[row, col]-=value;
				break;
		}
	}
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		Console.Write(matrix[i,j]+" ");
	}
	Console.WriteLine();
}