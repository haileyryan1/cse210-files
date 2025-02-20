using System;
using System.ComponentModel;
using System.Threading;

abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(String name, string description)
    {
        _name = name;
        _description = description;
    }
    
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name} Activity...");
        Console.WriteLine(_description);
        Console.Write("Enter duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine() ?? "30");
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
        RunActivity();
        End();
    }

    protected abstract void RunActivity();

    protected void End()
    {
        Console.WriteLine("Well done! You have completed the activity.");
        Console.WriteLine($"{_name} Activity Duration: {_duration} seconds");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int _seconds)
    {
        for (int i = 0; i<_seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountdown(int _seconds)
    {
        for (int i=_seconds; i>0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}