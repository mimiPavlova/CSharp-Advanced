

string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
ForEach(words, w=>Console.WriteLine(w));

static void ForEach(string[]arr, Action<string> action)
{
	foreach (var item in arr)
	{
		action(item);
	}
}