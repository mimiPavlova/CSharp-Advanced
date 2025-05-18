

int[] dementions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int r = dementions[0], c = dementions[1];
string[,] matrix = new string[r, c];

for (int i = 0; i < r; i++)
{
    string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
	for (int j = 0; j < c; j++)
	{
		matrix[i,j] = data[j];
	}
}

string command;
while ((command=Console.ReadLine())!="END")
{
	string []data = command.Split(" ");
	if (data.Length!=5)
	{
        Console.WriteLine("Invalid input!"); continue;
    }

    int r1 = int.Parse(data[1]);
	int c1 = int.Parse(data[2]);
	int r2=int.Parse(data[3]);
	int c2=int.Parse(data[4]);

	if (r1<0||r2<0||c1<0||c2<0||r1>=r||r2>=r||c1>=c||c2>=c||data[0]!="swap")
	{
		Console.WriteLine("Invalid input!"); continue;
	}

	string tempValue = matrix[r1, c1];
	matrix[r1, c1]=matrix[r2, c2];
	matrix[r2, c2]=tempValue;
	PrintMatrix(matrix);

	
}


static void PrintMatrix(string[,] m)
{
	for (int i = 0; i < m.GetLength(0); i++)
	{
		for (int j = 0; j < m.GetLength(1); j++)
		{
			Console.Write(m[i,j]+" ");
		}
		Console.WriteLine();
	}
}