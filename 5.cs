using System;

class Student
{
    // Properties
    public int RollNo { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }

    // Constructor
    public Student(int rollNo, string name, double marks)
    {
        RollNo = rollNo;
        Name = name;
        Marks = marks;
    }

    // Method to display student details
    public void Display()
    {
        Console.WriteLine("\nStudent Details:");
        Console.WriteLine("Roll No : " + RollNo);
        Console.WriteLine("Name    : " + Name);
        Console.WriteLine("Marks   : " + Marks);
    }
}

class Program
{
    static void Main()
    {
        int roll;
        string name;
        double marks;

        Console.Write("Enter Roll Number: ");
        roll = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        marks = Convert.ToDouble(Console.ReadLine());

        // Creating object using constructor
        Student s = new Student(roll, name, marks);

        // Display details
        s.Display();

        Console.ReadLine();
    }
}
