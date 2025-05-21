




Student[] students = new Student[]
{
new Student(){Name="Goshko", Age=42, Score=3.0},
new Student(){Name="Dimitrichko", Age=20, Score=2},
new Student(){Name="Pesho", Age=10, Score=6}
};





void PrintAllStudents(Student[] students, Action<Student> printer)
{
    foreach (var student in students)
    {
        printer(student);
    }
}


Action<Student> printer = GetPrinter(Console.ReadLine());
PrintAllStudents(students, printer);

Action<Student> GetPrinter(string type)
{
    Action<Student> printer = null;
    if (type=="age")
    {
        printer =s => Console.WriteLine(s.Age);
    }
    else if (type=="name")
    {
        printer=s => Console.WriteLine(s.Name);
    }
    else
    {
        printer=s => Console.WriteLine(s.Score);
    }
    return printer;
}

class Student
{
    public string Name;
    public int Age;
    public double Score;

}
