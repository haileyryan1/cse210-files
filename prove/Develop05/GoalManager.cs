class GoalManager
{
    private List<Goal> _goals;
    private int _totalScore;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    
    public void RecordGoalEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.GetName().Equals(goalName, StringComparison.OrdinalIgnoreCase))
            {
                _totalScore += goal.RecordEvent();
                return;
            }
        }
        Console.WriteLine($"Goal '{goalName}' not found.");
    }
    
    public void DisplayGoals()
    {
        Console.WriteLine("\nCurrent Goals:");
        foreach (var goal in _goals)
        {
            goal.DisplayStatus();
        }
        Console.WriteLine($"Total Score: {_totalScore}\n");
    }
    
    public void DeleteGoal(string goalName)
    {
        Goal goalToRemove = _goals.Find(g => g.GetName().Equals(goalName, StringComparison.OrdinalIgnoreCase));
        if (goalToRemove != null)
        {
            _goals.Remove(goalToRemove);
            Console.WriteLine($"Goal '{goalName}' has been deleted.");
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found.");
        }
    }

    public void SaveProgress(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalScore);
            foreach (var goal in _goals)
            {
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.GetName()},{goal.GetPoints()},{goal.IsCompleted()},{checklistGoal.GetCurrentCount()},{checklistGoal.GetTargetCount()},{checklistGoal.GetBonusPoints()}");
                }
                else
                {
                    writer.WriteLine($"{goal.GetType().Name},{goal.GetName()},{goal.GetPoints()},{goal.IsCompleted()}");
                }
            }
        }
    }

    public void LoadProgress(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("Save file not found.");
            return;
        }

        using (StreamReader reader = new StreamReader(filename))
        {
            _totalScore = int.Parse(reader.ReadLine());
            _goals.Clear();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                string type = data[0];
                string name = data[1];
                int points = int.Parse(data[2]);
                bool isCompleted = bool.Parse(data[3]);

                Goal goal = type switch
                {
                    "SimpleGoal" => new SimpleGoal(name, "Loaded Goal", points),
                    "EternalGoal" => new EternalGoal(name, "Loaded Goal", points),
                    "ChecklistGoal" => new ChecklistGoal(name, "Loaded Goal", points, 5, 50),
                    _ => null
                };

                if (goal != null)
                {
                    if (isCompleted) goal.RecordEvent();
                    _goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Progress loaded.");
    }
}