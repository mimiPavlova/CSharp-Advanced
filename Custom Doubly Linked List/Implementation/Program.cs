namespace Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CustomLinkedList list= new CustomLinkedList();
            list.AddFirst(1);
            Console.WriteLine(list.First.Value);

        }

    }
}
