using System;
using System.Collections.Generic;
using System.IO;

// I added a function in GoalManager where the user can delete a goal
// The menu reflects this action
class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();
        string _saveFile = "goals.txt";

        goalManager.LoadProgress(_saveFile);
        
        while (true)
        {
            Console.WriteLine("1. Create a Goal\n2. Record an Event\n3. Display Goals\n4. Delete a Goal \n5. Exit");
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                Console.Write("Enter goal name: ");
                string name = Console.ReadLine();
                Console.Write("Enter goal description: ");
                string description = Console.ReadLine();
                Console.Write("Enter goal points: ");
                int points = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose goal type: \n1) Simple \n2) Eternal \n3) Checklist");
                string typeChoice = Console.ReadLine();
                
                Goal newGoal = null;
                if (typeChoice == "1")
                {
                    newGoal = new SimpleGoal(name, description, points);
                }
                else if (typeChoice == "2")
                {
                    newGoal = new EternalGoal(name, description, points);
                }
                else if (typeChoice == "3")
                {
                    Console.Write("Enter target count: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    newGoal = new ChecklistGoal(name, description, points, target, bonus);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    continue;
                }
                
                goalManager.AddGoal(newGoal);
                Console.WriteLine("Goal added successfully!");
            }
            else if (choice == "2")
            {
                Console.Write("Enter goal name to record: ");
                goalManager.RecordGoalEvent(Console.ReadLine());
            }
            else if (choice == "3")
            {
                goalManager.DisplayGoals();
            }
            else if (choice == "4")
            {
                Console.Write("Enter goal name to delete: ");
                string goalName = Console.ReadLine();
                goalManager.DeleteGoal(goalName);
            }
            else if (choice == "5")
            {
                goalManager.SaveProgress(_saveFile);
                Console.WriteLine("Progress saved. Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please select a valid option.");
            }
        }
    }
}