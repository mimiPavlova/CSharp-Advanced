namespace _09.PredicateParty_
{
    internal class Program
    {
        static void Main(string[] args)
        {//(arg, name)=bool
            Dictionary<string, Func<string, string, bool>> FiltersMap = new Dictionary<string, Func<string, string, bool>>
            {
                ["StartsWith"]=(arg, name) => name.StartsWith(arg),
                ["EndsWith"]=(arg, name) => name.EndsWith(arg),
                ["Length"]=(arg, name) => name.Length.ToString()==arg
            };

            List<string> people=Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command;
            
            while ((command=Console.ReadLine())!="Party!")
            { 
                List<string> next = new List<string>();


                string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string operation=data[0];
                string filterName = data[1];
                string filterArg = data[2];
                Func<string, string, bool>filter=
                    FiltersMap[filterName];
               
                for (int i = 0; i < people.Count; i++)
                {

                    next.Add(people[i]);

                    if (filter(filterArg, people[i]))
                    {
                        if (operation=="Remove")
                        {
                            next.Remove(people[i]);
                        }

                        if (operation=="Double")
                        {
                            next.Add(people[i]);
                            
                        }
                    }
                   
                }
                people=next;

            }
            if (people.Count==0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
              Console.Write(string.Join(", ", people));
                Console.WriteLine(" are going to the party!");
            }
                
        }
    }
}
