using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string letterGrade = "Start";

        if (percentage >= 90)
        {
            letterGrade = "A";
        }   
        else if (percentage >=80)
        {
            letterGrade = "B";
        }
        else if (percentage >=70)
        {
            letterGrade = "C";
        }
        else if (percentage >=60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Grade: {letterGrade}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry! You failed the class, better luck next time.");
        }
    }
}