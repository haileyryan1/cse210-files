class GoalManager
{
    private List<Goal> _goals;
    private int _totalScore;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    public void addGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    
    public void recordGoalEvent(string goalName)
    {
        foreach (var goal in _goals)
        {
            if (goal.GetName() == goalName)
            {
                goal.recordEvent();
                _totalScore += goal.GetPoints();
                return;
            }
        }
        Console.WriteLine($"Goal {goalName} not found.");
    }
    
    public void displayGoals()
    {
        Console.WriteLine("\nCurrent Goals: ");
        foreach (var goal in _goals)
        {
            goal.displayStatus();
        }
        Console.WriteLine($"Total Score: {_totalScore}");
    }
    
    public void saveProgress(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalScore);
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.GetName()},{goal.GetPoints()},{goal.IsCompleted()}");
            }
        }
        Console.WriteLine("Progress saved.");
    }

    public void loadProgress(string filename)
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
                    "ChecklistGoal" => new ChecklistGoal(name, "Loaded Goal", points, 5, 10),
                    _ => null
                };

                if (goal != null)
                {
                    if (isCompleted) goal.recordEvent();
                    _goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Progress loaded.");
    }
}