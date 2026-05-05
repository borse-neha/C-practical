using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// 225. Program to demonstrate LINQ advanced (grouping and joining)
// Generated as a standalone sample file.
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int GradeId { get; set; }
}

public class Grade
{
    public int Id { get; set; }
    public string GradeName { get; set; }
}

public class Problem225
{
    public static async Task Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", GradeId = 1 },
            new Student { Id = 2, Name = "Bob", GradeId = 2 },
            new Student { Id = 3, Name = "Charlie", GradeId = 1 }
        };

        List<Grade> grades = new List<Grade>
        {
            new Grade { Id = 1, GradeName = "A" },
            new Grade { Id = 2, GradeName = "B" }
        };

        var joined = from s in students
                     join g in grades on s.GradeId equals g.Id
                     select new { s.Name, g.GradeName };

        foreach (var item in joined)
        {
            Console.WriteLine($"{item.Name}: {item.GradeName}");
        }

        await Task.CompletedTask;
    }
}