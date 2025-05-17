int[]data=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int n = data[0], s = data[1], x=data[2];

int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

Queue<int>q=new Queue<int>(numbers);
bool isFound = false;

for (int i = 0; i < s; i++)
{
    q.Dequeue();
}


foreach (var item in q)
{
    if (item==x) { Console.WriteLine("true"); isFound = true; break; }
}

if (q.Count==0) { Console.WriteLine(0); }
else
{
 if (!isFound)
    {
        int smallest = int.MaxValue;
        foreach (var item in q)
        {
            if (item<smallest) smallest = item;
        }
        Console.WriteLine(smallest);
    }

}
 