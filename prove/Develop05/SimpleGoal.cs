using System.Security.Cryptography.X509Certificates;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points){}

    public override void recordEvent()
    {
       if (!_isCompleted)
       {
        _isCompleted = true;
        Console.WriteLine($"Goal {_name} completed! +{_points} points.");
       }
       else
       {
            Console.WriteLine($"Goal {_name} was already completed.");
       }
    }

    public override void displayStatus()
    {
        Console.WriteLine($"[Simple Goal] {_name} - {(_isCompleted ? "Completed" : "Not Completed")}");
    }
}