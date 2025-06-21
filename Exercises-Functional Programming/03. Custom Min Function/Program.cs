int[]numbers=Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    . ToArray();


int min = Aggregate(numbers, (num, min) => num>min ? min : num, numbers[0]);
Console.WriteLine(min);
static int Aggregate(int[]numbers, Func<int,int, int> func, int initial)
{
    int aggregate = initial;
    foreach (int n in numbers)
    {
        aggregate=func(n,aggregate);
    }
    return aggregate;
}