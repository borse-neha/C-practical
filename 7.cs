using System;

// Interface
interface IEmployee
{
    void DisplayDetails();
    double CalculateSalary();
}

// Class 1: Full-Time Employee
class FullTimeEmployee : IEmployee
{
    public int EmpId { get; set; }
    public string Name { get; set; }
    public double MonthlySalary { get; set; }

    public FullTimeEmployee(int id, string name, double salary)
    {
        EmpId = id;
        Name = name;
        MonthlySalary = salary;
    }

    public double CalculateSalary()
    {
        return MonthlySalary;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\nFull-Time Employee Details:");
        Console.WriteLine("ID     : " + EmpId);
        Console.WriteLine("Name   : " + Name);
        Console.WriteLine("Salary : " + CalculateSalary());
    }
}

// Class 2: Part-Time Employee
class PartTimeEmployee : IEmployee
{
    public int EmpId { get; set; }
    public string Name { get; set; }
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public PartTimeEmployee(int id, string name, double rate, int hours)
    {
        EmpId = id;
        Name = name;
        HourlyRate = rate;
        HoursWorked = hours;
    }

    public double CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\nPart-Time Employee Details:");
        Console.WriteLine("ID     : " + EmpId);
        Console.WriteLine("Name   : " + Name);
        Console.WriteLine("Salary : " + CalculateSalary());
    }
}

class Program
{
    static void Main()
    {
        IEmployee emp1 = new FullTimeEmployee(101, "Apoorv", 50000);
        IEmployee emp2 = new PartTimeEmployee(102, "Ravi", 500, 40);

        emp1.DisplayDetails();
        emp2.DisplayDetails();

        Console.ReadLine();
    }
}
