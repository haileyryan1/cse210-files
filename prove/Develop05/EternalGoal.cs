class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        Console.WriteLine($"Goal '{_name}' recorded! +{_points} points.");
        return _points;
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"[Eternal Goal] {_name} - Always ongoing");
    }
}
