string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

ForEach(words, w => Console.WriteLine($"Sir {w}"));
static void ForEach(string[] words, Action<string> action)
{
	foreach (var item in words)
	{
		action(item);
	}
}