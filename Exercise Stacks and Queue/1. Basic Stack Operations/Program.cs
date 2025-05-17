
int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int n = input[0];
int s = input[1];
int x = input[2];

Stack<int>stack= new Stack<int>(Console.ReadLine().Split(" ")
    .Select(int.Parse).ToArray());

for (int i = 0; i < s; i++)
{
    stack.Pop();
}

int smallestElement = int.MaxValue;
bool isFound = false;
foreach (var element in stack)
{
    if (element==x)
    {
        Console.WriteLine("true"); isFound=true; break;
    } 
    if (element < smallestElement)
   {
        smallestElement=element;
   } 

}

if (!isFound)
{
    if (stack.Count==0) { Console.WriteLine(0); }
    else { Console.WriteLine(smallestElement); }
}
