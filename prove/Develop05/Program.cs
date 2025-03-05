using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        goalManager.addGoal(new SimpleGoal("Run a Marathon", "Complete a full marathon", 100));
        goalManager.addGoal(new EternalGoal("Daily Exercise", "Exercise every day", 10));
        goalManager.addGoal(new ChecklistGoal("Read Books", "Read 5 books", 20, 5, 50));

        goalManager.displayGoals();

        goalManager.recordGoalEvent("Daily Exercise");
        goalManager.recordGoalEvent("Read Books");
        goalManager.recordGoalEvent("Read Books");

        goalManager.displayGoals();

        goalManager.saveProgress("goals.txt");
        goalManager.loadProgress("goals.txt");
    }
}