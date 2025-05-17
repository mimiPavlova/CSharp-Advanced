

Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));
while (songs.Count>0)
{
    string[] input= Console.ReadLine().Split(" ");
	string commant = input[0];
	switch (commant)
	{
		case "Play": songs.Dequeue(); break;
		case "Add":
			string song = string.Join(" ", input.Skip(1));
			if (songs.Contains(song))
			{
				Console.WriteLine($"{song} is already contained!");
			}
			else
			{
				songs.Enqueue(song);
			}
			break;
		case "Show":
			Console.WriteLine(string.Join(", ", songs));
			break;
	}
}
Console.WriteLine("No more songs!");