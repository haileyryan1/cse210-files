class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            Console.WriteLine($"Goal '{_name}' completed! +{_points} points.");
            return _points;
        }
        Console.WriteLine($"Goal '{_name}' was already completed.");
        return 0;
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"[Simple Goal] {_name} - {(_isCompleted ? "Completed" : "Not Completed")}");
    }
}