using System.ComponentModel;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]food=Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[]stamina=Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

           Stack<int> stack = new Stack<int>(food);
           Queue<int> queue = new Queue<int>(stamina);

            List<string> conqueredPeaks = new List<string>();
            List<Peak> _peaks = new List<Peak>()
            {
                new Peak("Vihren", 80),
                new Peak("Kutelo", 90),
                new Peak("Banski Suhodol", 100),
                new Peak("Polezhan", 60),
                new Peak("Kamenitza", 70)
            };


            int days = 0;

             while(days<7&&_peaks.Count >0&&stack.Count>0&&queue.Count>0)
            {
                int power=stack.Pop()+queue.Dequeue();
                if(power >=_peaks[0].Difficulty)
                {
                    conqueredPeaks.Add(_peaks[0].Name);
                    _peaks.RemoveAt(0);
                }
                days++;
            }


            if (_peaks.Count == 0)
            {
                Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
            }
            else 
            {
               
                Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");

            }


            if(conqueredPeaks.Count>0)
            {
                Console.WriteLine("Conquered peaks:");
                for (int i = 0; i < conqueredPeaks.Count; i++)
                {
                    Console.WriteLine(conqueredPeaks[i]);
                }
            }
        }
        class Peak
        {
            public string Name {  get; set; }
            public int Difficulty { get; set; }
            public Peak(string name, int dificulty)
            {
                Name = name;
                Difficulty = dificulty;
            }
        }
    }
}
