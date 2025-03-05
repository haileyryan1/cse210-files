class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points){}

    public override void recordEvent()
    {
        Console.WriteLine($"Goal '{_name}' recorded! +{_points} points.");
    }

    public override void displayStatus()
    {
        Console.WriteLine($"[Eternal Goal] {_name} - Always ongoing");
    }

}