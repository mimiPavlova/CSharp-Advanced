

int[]data=Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rols = data[0], cols = data[1];
int[,] matrix = new int[rols, cols];
int Sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
	int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
	
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		matrix[i, j]=elements[j];
		Sum+=elements[j];
	}
	
}
Console.WriteLine(rols);
	Console.WriteLine(cols);
	Console.WriteLine(Sum);