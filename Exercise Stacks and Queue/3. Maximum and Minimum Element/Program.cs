int n=int.Parse(Console.ReadLine());
Stack<int>stack=new Stack<int>();
for (int i = 0; i < n; i++)
{
    string[] data = Console.ReadLine().Split(" ");
    int type=int.Parse(data[0]);
    
    switch (type)
    {
        case 1: int value = int.Parse(data[1]);stack.Push(value); break;
        case 2:stack.Pop(); break;
        case 3:if (stack.Count>0) { int max = stack.Max(); Console.WriteLine(max); } break;
        case 4: if (stack.Count>0) { int min = stack.Min(); Console.WriteLine(min); } break;

    }
}
Console.WriteLine(string.Join(", ", stack));