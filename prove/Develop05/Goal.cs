abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public abstract void recordEvent();

    public abstract void displayStatus();

    public string GetName() => _name;
    public int GetPoints() => _points;
    public bool IsCompleted() => _isCompleted;
}