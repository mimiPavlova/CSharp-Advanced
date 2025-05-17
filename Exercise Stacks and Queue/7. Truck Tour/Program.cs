

int N = int.Parse(Console.ReadLine());
Queue<(int Fuel, int Distance)> stations = new Queue<(int Fuel, int Distance)>();

for (int i = 0; i < N; i++)
{
    int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    int liters=data[0];
    int kilometers=data[1];
    stations.Enqueue((liters, kilometers));

}
int succsessIndex = 0;
for (int i = 0; i < N; i++)
{
    int capacity = 0;
    bool success = true;
    foreach (var (fuel, distance) in stations)
    {
        capacity+=fuel;
        if (capacity<distance) { success=false; break; }
        capacity-=distance;
        
    }
    var station = stations.Dequeue();
    stations.Enqueue(station);
    if (success==true) { succsessIndex=i; break; }
}
Console.WriteLine(succsessIndex);