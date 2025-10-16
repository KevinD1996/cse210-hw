using System;
class Program
{
    static void Main(string[] args)
    {

        

        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.WriteLine("Track your goals, earn points, and stay motivated on your Eternal Quest.\n");

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}













// public class EternalQuestProgram
// {
//     private List<Goal> _goals = new List<Goal>();
//     private int _score = 0;

//     public void Run()
//     {
//         Console.WriteLine("Welcome to the Eternal Quest Program!");

//         int choice;
//         do
//         {
//             DisplayMenu();
//             Console.Write("Enter your choice: ");
//             if (int.TryParse(Console.ReadLine(), out choice))
//             {
//                 switch (choice)
//                 {
//                     case 1:
//                         CreateNewGoal();
//                         break;
//                     case 2:
//                         ListGoals();
//                         break;
//                     case 3:
//                         RecordEvent();
//                         break;
//                     case 4:
//                         Console.WriteLine($"Current Score: {_score}");
//                         break;
//                     case 5:
//                         Console.WriteLine("Exiting program. Goodbye!");
//                         break;
//                     default:
//                         Console.WriteLine("Invalid choice. Please try again.");
//                         break;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input. Please enter a number.");
//             }
//             Console.WriteLine();
//         } while (choice != 7);
//     }

//     private void DisplayMenu()
//     {
//         Console.WriteLine("\nMenu Option:");
//         Console.WriteLine("1. Create New Goal");
//         Console.WriteLine("2. List Goals");
//         Console.WriteLine("3. Save Goals");
//         Console.WriteLine("4. Load Goals");
//         Console.WriteLine("5. Record Event");
//         Console.WriteLine("6. Display Score");
//         Console.WriteLine("7. Quit");
//         Console.WriteLine("Select a choice from the menu:");
//         Console.ReadLine();
//     }

//     private void CreateNewGoal()
//     {
//         Console.WriteLine("\n--- Create New Goal ---");
//         Console.WriteLine("Select Goal Type:");
//         Console.WriteLine("1. Simple Goal");
//         Console.WriteLine("2. Eternal Goal");
//         Console.WriteLine("3. Checklist Goal");
//         Console.Write("Enter goal type: ");
//         if (int.TryParse(Console.ReadLine(), out int typeChoice))
//         {
//             Console.Write("Enter goal name: ");
//             string name = Console.ReadLine();
//             Console.Write("Enter goal description: ");
//             string description = Console.ReadLine();
//             Console.Write("Enter points for completing/recording this goal: ");
//             if (int.TryParse(Console.ReadLine(), out int points))
//             {
//                 switch (typeChoice)
//                 {
//                     case 1:
//                         _goals.Add(new SimpleGoal(name, description, points));
//                         Console.WriteLine("Simple Goal created successfully.");
//                         break;
//                     case 2:
//                         _goals.Add(new EternalGoal(name, description, points));
//                         Console.WriteLine("Eternal Goal created successfully.");
//                         break;
//                     case 3:
//                         Console.Write("Enter target count for this checklist goal: ");
//                         if (int.TryParse(Console.ReadLine(), out int targetCount))
//                         {
//                             Console.Write("Enter bonus points for completing the checklist: ");
//                             if (int.TryParse(Console.ReadLine(), out int bonusPoints))
//                             {
//                                 _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
//                                 Console.WriteLine("Checklist Goal created successfully.");
//                             }
//                             else { Console.WriteLine("Invalid bonus points."); }
//                         }
//                         else { Console.WriteLine("Invalid target count."); }
//                         break;
//                     default:
//                         Console.WriteLine("Invalid goal type.");
//                         break;
//                 }
//             }
//             else { Console.WriteLine("Invalid points value."); }
//         }
//         else { Console.WriteLine("Invalid input for goal type."); }
//     }

//     private void ListGoals()
//     {
//         Console.WriteLine("\n--- Your Goals ---");
//         if (_goals.Count == 0)
//         {
//             Console.WriteLine("No goals created yet.");
//             return;
//         }
//         for (int i = 0; i < _goals.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
//         }
//     }

//     private void RecordEvent()
//     {
//         Console.WriteLine("\n--- Record Event ---");
//         ListGoals();
//         if (_goals.Count == 0) return;

//         Console.Write("Enter the number of the goal to record an event for: ");
//         if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
//         {
//             Goal selectedGoal = _goals[goalIndex - 1];
//             selectedGoal.RecordEvent();
//             _score += selectedGoal.Points;

//             // Handle bonus points for ChecklistGoal completion
//             if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.CurrentCount == checklistGoal.TargetCount)
//             {
//                 _score += checklistGoal.BonusPoints;
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid goal number.");
//         }
//     }

//     public static void Main(string[] args)
//     {
//         EternalQuestProgram program = new EternalQuestProgram();
//         program.Run();
//     }
// }




