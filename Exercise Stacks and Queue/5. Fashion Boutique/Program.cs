
int[]data=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
Stack<int>clotes=new Stack<int>(data);
int rackCapacity = int.Parse(Console.ReadLine());
int racks = 1;
int currentRackCapasity = rackCapacity;
while (clotes.Count!=0)
{
    int value=clotes.Pop();
    if (currentRackCapasity<value)
    {
        racks++;
        currentRackCapasity=rackCapacity-value;
    }
    else
    {
        currentRackCapasity-=value;
    }

}
Console.WriteLine(racks);
