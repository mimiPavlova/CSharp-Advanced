using System.Runtime.ConstrainedExecution;

namespace _05.ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person>people = new List<Person>();
            string command;
            while ((command=Console.ReadLine())!="END")
            {
                string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person { Name=data[0], Age=int.Parse(data[1]), Town=data[2]};
               people.Add(person);
            }
            
            int positon=int.Parse(Console.ReadLine());

            Person requestedPerson = people[positon-1];
            int matches = 0;
            foreach (Person p in people)
            {
                if(Comparer<Person>.Default.Compare(requestedPerson, p) == 0)
                {
                    matches++;
                }
            }
            if (matches==1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {people.Count-matches} {people.Count}");
            }
        }
    }
}
