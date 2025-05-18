
int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int rols = data[0], cols = data[1];
char[,] arr = new char[rols, cols];
for (int i = 0; i <rols; i++)
{
	char[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
	for (int j = 0; j < cols; j++)
	{
		arr[i,j]= text[j];
	}
}
int count = 0;
for (int i = 0; i < rols-1; i++)
{
	for (int j = 0; j < cols-1; j++)
	{
		if (arr[i, j]==arr[i, j+1]&&arr[i+1, j]==arr[i+1, j+1]&&arr[i, j]==arr[i+1, j])
		{
			count++;
		}
	}
}
Console.WriteLine(count);