using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade (0-100): ");
        double grade = Convert.ToDouble(Console.ReadLine());

        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid grade. Please enter a grade between 0 and 100.");
        }
        else if (grade >= 90)
        {
            Console.WriteLine("Your Letter Grade is: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your Letter Grade is: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your Letter Grade is: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your Letter Grade is: D");
        }
        else
        {
            Console.WriteLine("Your Letter Grade is: F");
        }
    }
}
