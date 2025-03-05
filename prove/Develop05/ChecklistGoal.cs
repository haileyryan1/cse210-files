class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void recordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            Console.WriteLine($"Goal '{_name}' recorded! +{_points} points. ({_currentCount}/{_targetCount})");

            if (_currentCount == _targetCount)
            {
                _isCompleted = true;
                Console.WriteLine($"Goal '{_name}' fully completed! Bonus +{_bonusPoints} points!");
            }
        }
    }

    public override void displayStatus()
    {
        Console.WriteLine($"[Checklist Goal] {_name} - {_currentCount}/{_targetCount} completed {(_isCompleted ? "(Completed)" : "")}");
    }
}
