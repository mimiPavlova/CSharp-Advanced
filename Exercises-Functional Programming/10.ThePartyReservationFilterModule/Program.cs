using System.Data;

namespace _10.ThePartyReservationFilterModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> filters = new List<string>();   

            List<string> invitations = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();


            string command;

            while ((command=Console.ReadLine())!="Print")
            {
                 string[] data = command.Split(";");

                string filterType = data[1];
                string arg = data[2];
                string filter = filterType+"->"+arg;

                if (data[0]=="Add filter")
                {
                  filters.Add(filter);
                }
                else if(data[0]=="Remove filter")
                {
                    filters.Remove(filter);
                }
            }
            invitations=FilterInvitations(invitations,filters);
            Console.WriteLine(string.Join(" ", invitations));

        }
        static List<string>FilterInvitations(List<string> invitations, List<string> filters)
        {

            
            for (int i = 0; i < filters.Count; i++)
            {
                string[] data = filters[i].Split("->");
                string arg = data[1];
                Func<string, bool> func = null;
                switch (data[0])
                {
                    case "Starts with": func=name=> name.StartsWith(arg); break;
                    case "Ends with":func=name => name.EndsWith(arg); break;
                    case "Contains": func= name => name.Contains(arg);break;
                    case "Length": func=name=>name.Length.ToString()==arg; break;


                }

                if(func!= null)
                {
                    invitations=invitations.Where(name=>!func(name)).ToList();
                }
                
            }
           return invitations;

        }
    }
}
