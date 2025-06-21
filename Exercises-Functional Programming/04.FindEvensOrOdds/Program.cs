
Dictionary<string, Predicate<int>> predicatesByCommand = new Dictionary<string, Predicate<int>>
{
    ["even"]=num=>num%2==0,
    ["odd"]=num=>num%2!=0
};

int[] rangeParameters = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();

int start = rangeParameters[0], end = rangeParameters[1];

string command=Console.ReadLine();



Predicate<int> predicate;
if (predicatesByCommand.ContainsKey(command))
{
    predicate = predicatesByCommand[command];
}
else
{
    predicate = _ => false;
}


var result=Filter(start, end, predicate);
Console.WriteLine(string.Join(" ", result));

static List<int>Filter(int start, int end, Predicate<int> condition)
{
    List<int> result=new List<int>();
    for (int i = start; i <=end; i++)
    {
        if (condition(i))
        {
            result.Add(i);
        }
    }
    return result;
}
