

int foodQuantity=int.Parse(Console.ReadLine());
int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
Queue<int> orders=new Queue <int>(data);
int max=orders.Max();
Console.WriteLine(max);
while (foodQuantity>0&&orders.Count!=0)
{ 
    int order=orders.Peek();
    if (foodQuantity<order) { break; }
    else { foodQuantity-=orders.Dequeue(); }
  
}

if(orders.Count==0)
{
    Console.WriteLine("Orders complete");
}
else
{ 
    Console.Write("Orders left: ");
    Console.WriteLine(string.Join(" ", orders));
}
