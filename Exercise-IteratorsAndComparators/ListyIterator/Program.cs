namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create el1, el2, el3
            string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            ListyIterator<string> iterator = new ListyIterator<string>(data.Skip(1));

            string command;
            while ((command=Console.ReadLine())!="END")
            {

                try
                {
                    if (command=="Move")
                    {


                        Console.WriteLine(iterator.Move());
                    }
                    else if (command=="Print")
                    {
                        Console.WriteLine(iterator.Current);
                    }
                    else if (command=="HasNext")
                    {
                        Console.WriteLine(iterator.HasNext());
                    }
                    else if (command=="PrintAll")
                    {
                        Console.WriteLine(string.Join(" ", iterator));
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }


            }

        }
    }
}
