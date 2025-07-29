using System.Collections;

namespace _01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> timeValues = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());

            Stack<int> taskValues = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());


            List<RubberDucky> rubberDuckies = new List<RubberDucky>()
           {
                new RubberDucky("Darth Vader Ducky",0,60 ),
                new RubberDucky("Thor Ducky", 61, 120),
                new RubberDucky("Big Blue Rubber Ducky", 121, 180),
                new RubberDucky("Small Yellow Rubber Ducky", 181, 240)

           };

            Dictionary<string, int> result = new Dictionary<string, int>()
            {
                ["Darth Vader Ducky"]=0,
                ["Thor Ducky"]=0,
                ["Big Blue Rubber Ducky"]=0,
                ["Small Yellow Rubber Ducky"]=0
            };

            while (timeValues.Count>0&&taskValues.Count>0)
            {
                int time = timeValues.Dequeue();
                int task = taskValues.Pop();
                int total = time*task;

                RubberDucky ducky = rubberDuckies.FirstOrDefault(r => r.TimeRange.Key<=total&&r.TimeRange.Value>=total);
                if (ducky == null)
                {
                    timeValues.Enqueue(time);
                    taskValues.Push(task-2);
                    continue;
                }

                result[ducky.Name]++;



            }

            if (taskValues.Count==0)
            {
                Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");

            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        public class RubberDucky
        {
            public string Name { get; set; }
            public KeyValuePair<int, int> TimeRange { get; set; }

            public RubberDucky(string name, int a, int b)
            {
                Name=name;
                TimeRange= new KeyValuePair<int, int>(a, b);
            }
        }

    }
}