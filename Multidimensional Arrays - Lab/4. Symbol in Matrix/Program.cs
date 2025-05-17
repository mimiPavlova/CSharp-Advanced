

int n = int.Parse(Console.ReadLine());
char[,] matrix = new char[n, n];
for (int i = 0; i < n; i++)
{
    string data = Console.ReadLine();
	for (int j = 0; j <n; j++)
	{
		matrix[i, j]=data[j];
	}
}
char simbol = char.Parse(Console.ReadLine());
bool isFound = false;
for (int i = 0; i < n; i++)
{
	for (int j = 0; j < n; j++)
	{
		if (matrix[i, j] == simbol)
		{
			Console.WriteLine($"({i}, {j})");
			isFound = true;
			break;
		}
	}
	if (isFound) break;
}
if (!isFound) Console.WriteLine($"{simbol} does not occur in the matrix");