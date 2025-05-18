namespace _6.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wordrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" -> ");
                string color=data[0];
                string[] clotes = data[1].Split(",").ToArray();

                if(!wordrobe.ContainsKey(color))wordrobe.Add(color, new Dictionary<string, int>());
                foreach (var item in clotes)
                {
                    if (!wordrobe[color].ContainsKey(item)) wordrobe[color][item]=0;

                    wordrobe[color][item]++;
                }
                

            }
            string[] reserchReqest = Console.ReadLine().Split(" ");
            string colorOfClote = reserchReqest[0], clote = reserchReqest[1];
            foreach (var (c,clotes) in wordrobe)
            {
                Console.WriteLine($"{c} clothes:");

                foreach (var (item,value) in clotes)
                {
                    string ex = string.Empty;
                    if (c==colorOfClote&&item==clote) { ex=" (found!)"; }
                   
                    
                        Console.WriteLine($"* {item} - {value}{ex}");
                    
                }

            }

        }
    }
}
