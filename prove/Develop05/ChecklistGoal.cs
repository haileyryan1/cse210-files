class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int currentCount = 0) : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            int totalPoints = _points;
            Console.WriteLine($"Goal '{_name}' recorded! +{_points} points. ({_currentCount}/{_targetCount})");

            if (_currentCount == _targetCount)
            {
                _isCompleted = true;
                totalPoints += _bonusPoints;
                Console.WriteLine($"Goal '{_name}' fully completed! Bonus +{_bonusPoints} points!");
            }
            return totalPoints;
        }
        return 0;
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"[Checklist Goal] {_name} - {_currentCount}/{_targetCount} completed {(_isCompleted ? "(Completed)" : "")}");
    }

    public int GetCurrentCount() => _currentCount;
    public int GetTargetCount() => _targetCount;
    public int GetBonusPoints() => _bonusPoints;
}


