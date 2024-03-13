using System.Runtime.ExceptionServices;

class Student
{
    // auto-implemented properties
    public int Id { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }


    public Student(int id)
    {
        Id = id;
        FirstName = "";
        LastName = "";
    }
    // default constructor
    public Student()
    {
        Id = 0;
        FirstName = "";
        LastName = "";
    }
    // parameterized constructor
    public Student(int i, string First, string Last)
    {
        Id = i;
        FirstName = First;
        LastName = Last;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(1);
        student1.FirstName = "Nick";
        student1.LastName = "Petrie";

        Student student2 = new Student(2, "Myles", "Petrie");
        Console.WriteLine($"{student1.Id} {student1.FirstName} {student1.LastName}");
        Console.WriteLine($"{student2.Id} {student2.FirstName} {student2.LastName}");

    }
}