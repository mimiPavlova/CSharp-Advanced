

int n = int.Parse(Console.ReadLine());
long[][]triangle= new long[n][];

triangle[0]=new long[] { 1 };

for (int r = 1; r <n; r++)
{
	triangle[r]=new long[triangle[r-1].Length+1];
	for (int c = 0; c <triangle[r].Length; c++)
	{
		if (c==0||c==triangle[r].Length-1)
		{
			triangle[r][c]=1;
		}
		else
		{
			triangle[r][c]=triangle[r-1][c]+triangle[r-1][c-1];
		}
	}
}


foreach (var item in triangle)
{
	Console.WriteLine(string.Join(" ", item));
}

