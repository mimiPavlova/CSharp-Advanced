using System.Xml.Linq;

int n = int.Parse(Console.ReadLine());
List<Student> students = new List<Student>(n);
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ");
    string name=input[0];
    int age = int.Parse(input[1]);
    Student student = new Student(name, age);
    students.Add(student);

}


string fileterType = Console.ReadLine();
int ageFileter = int.Parse(Console.ReadLine());

Func<Student, bool> filter = GetFilter(fileterType, ageFileter);
students=students.Where(filter).ToList();
Func<Student, string> formater = GetFormater(Console.ReadLine());
foreach (var item in students)
{
    Console.WriteLine(formater(item)); 
}


Func<Student, string>GetFormater(string type)
{
    switch (type)
    {
        case "name":
            return s => s.Name;
            break;
        case "age":
            return s => s.Age.ToString();
            break;
        case "name age":
            return s => $"{s.Name} - {s.Age}";
            break;
        default:return null; break;

    }
}

Func<Student, bool>GetFilter(string type, int age)
{
    if (type=="older")
    {
        return s=>s.Age>=age;
    }
    else
    {
        return s => s.Age<age;
    }
}
 public record class Student (string Name, int Age);
