

int[]dementions=Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
string word=Console.ReadLine();
int r = dementions[0], c = dementions[1];

char[][] matrix = new char[r][];
for (int i = 0; i < r; i++)
{
    matrix[i]=new char[c];

}

int position = 0;
for (int i = 0; i < r; i++)
{
	for (int j = 0; j < c; j++)
	{
		int col;
		if (i%2==0)
		{
			col=j;
		}
		else
		{
			col=c-(j+1); 

		}
		matrix[i][col]= word[position];
		position=(position+1)%word.Length;
	}
}
for (int i = 0; i < r; i++)
{
	Console.WriteLine(string.Join("", matrix[i]));
}