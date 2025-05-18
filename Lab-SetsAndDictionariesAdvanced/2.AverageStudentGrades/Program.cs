namespace _2.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> register = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string student=data[0];
                decimal grade = decimal.Parse(data[1]);
                if(register.ContainsKey(student))
                {
                    register[student].Add(grade);
                }
                else
                {
                    register[student] = new List<decimal>();
                    register[student].Add((decimal)grade);
                }

            }
            foreach (var student in register)
            {
                decimal average = student.Value.Average();
                Console.Write(student.Key+" -> ");
                foreach(var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {average:f2})");
                Console.WriteLine();

            }
        }
    }
}
