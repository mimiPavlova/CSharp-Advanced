namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
           
           int n=int.Parse(Console.ReadLine());
            Family family=new Family();
            for (int i = 0; i < n; i++)
            {

                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


                family.AddMember(new Person(data[0], int.Parse(data[1])));
            }

            var olderThan30 = FindOlderThan30(family, age => age>30);
            var result=olderThan30.OrderBy(x=>x.Name).ToList();
            foreach (var member in result)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
        static List<Person>FindOlderThan30(Family family, Func<int, bool> func)
        {
            List<Person> list = new List<Person>();
            for (int i = 0; i < family.Members.Count; i++)
            {
                if (func(family.Members[i].Age))
                {
                    list.Add(family.Members[i]);
                }
            }
            return list;
        }
    }
}
