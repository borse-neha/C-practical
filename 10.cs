using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        students.Add(new Student { RollNo = 1, Name = "Apoorv", Marks = 85 });
        students.Add(new Student { RollNo = 2, Name = "Ravi", Marks = 72 });
        students.Add(new Student { RollNo = 3, Name = "Neha", Marks = 90 });
        students.Add(new Student { RollNo = 4, Name = "Karan", Marks = 65 });

        Console.WriteLine("All Student Records:");
        foreach (var s in students)
        {
            Console.WriteLine($"{s.RollNo}  {s.Name}  {s.Marks}");
        }

        // Search using LINQ
        Console.Write("\nEnter roll number to search: ");
        int roll = Convert.ToInt32(Console.ReadLine());

        var searchResult = students.FirstOrDefault(s => s.RollNo == roll);

        if (searchResult != null)
        {
            Console.WriteLine($"Student Found: {searchResult.Name}, Marks: {searchResult.Marks}");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }

        // Filter using LINQ
        Console.WriteLine("\nStudents with Marks >= 75:");
        var filteredStudents = students.Where(s => s.Marks >= 75);

        foreach (var s in filteredStudents)
        {
            Console.WriteLine($"{s.RollNo}  {s.Name}  {s.Marks}");
        }

        Console.ReadLine();
    }
}
