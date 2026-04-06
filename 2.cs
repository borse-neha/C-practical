using System;

class Program
{
    static void Main()
    {
        int choice;

        Console.WriteLine("1. Check Even or Odd");
        Console.WriteLine("2. Display Multiplication Table");
        Console.Write("Enter your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                    Console.WriteLine(num + " is Even");
                else
                    Console.WriteLine(num + " is Odd");
                break;

            case 2:
                Console.Write("Enter a number: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nMultiplication Table:");

                // for loop
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(n + " x " + i + " = " + (n * i));
                }

                // while loop (simple demonstration)
                int count = 1;
                while (count <= 1)
                {
                    Console.WriteLine("\nTable displayed using while loop.");
                    count++;
                }

                // do-while loop (simple demonstration)
                int flag = 1;
                do
                {
                    Console.WriteLine("Table displayed using do-while loop.");
                    flag++;
                } while (flag <= 1);

                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        Console.ReadLine();
    }
}
