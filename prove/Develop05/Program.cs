using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int choice = 0;
        int total = 0;
        
        List<Goal> goals = new List<Goal>();

        while(choice != 6){
            Console.WriteLine($"You have {total} points.\n");

            Console.WriteLine($"Menu Options:");
            Console.WriteLine($"  1. Create New Goal");
            Console.WriteLine($"  2. List Goals");
            Console.WriteLine($"  3. Save Goals");
            Console.WriteLine($"  4. Load Goals");
            Console.WriteLine($"  5. Record Event");
            Console.WriteLine($"  6. Quit");
            Console.Write("Select a choice from the Menu: ");
            choice = int.Parse(Console.ReadLine());

            if(choice == 1){
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("  1. Simple Goals");
                Console.WriteLine("  2. Eternal Goals");
                Console.WriteLine("  3. Checklist Goals");
                Console.Write("What type of Goal would you like to create: ");
                int selector = int.Parse(Console.ReadLine());

                if (selector == 1){
                    Console.Write("What is the name of your goal: ");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description of it: ");
                    string desc = Console.ReadLine();

                    Console.Write("What is the amount of points assossiated with it.  ");
                    int points = int.Parse(Console.ReadLine());

                    SimpleGoal goal = new SimpleGoal(name, desc, points);
                    goals.Add(goal);
                }
                else if(selector == 2){
                    Console.Write("What is the name of your goal: ");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description of it: ");
                    string desc = Console.ReadLine();

                    Console.Write("What is the amount of points assossiated with it.  ");
                    int points = int.Parse(Console.ReadLine());

                    EternalGoal goal = new EternalGoal(name, desc, points);
                    goals.Add(goal);
                }
                else if(selector == 3){
                    Console.Write("What is the name of your goal: ");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description of it: ");
                    string desc = Console.ReadLine();

                    Console.Write("How many times does this goal need to be accomplished: ");
                    int complete = int.Parse(Console.ReadLine());

                    Console.Write("What is the amount of points assossiated with it.  ");
                    int points = int.Parse(Console.ReadLine());

                    Console.Write("What is the amount of bonus points assossiated with it.  ");
                    int bonus = int.Parse(Console.ReadLine());


                    ChecklistGoal goal = new ChecklistGoal(name, desc, complete, points, bonus);
                    goals.Add(goal);
                }
            }

            else if(choice == 2){
                Console.WriteLine("");
                foreach(Goal goal in goals){
                    goal.Display();
                }
                Console.WriteLine("");
            }
            else if(choice == 3){
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                using(StreamWriter outputFile = new StreamWriter(filename)){
                    outputFile.WriteLine(total);

                    foreach(Goal goal in goals){
                        outputFile.WriteLine(goal.GetSaveString());
                    }
                }

                Console.WriteLine("Goals saved successfully.");
            }
            else if(choice == 4){
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                if(File.Exists(filename)){
                    goals.Clear();

                    using(StreamReader inputFile = new StreamReader(filename)){
                        total = int.Parse(inputFile.ReadLine());

                        string line;

                        while((line = inputFile.ReadLine()) != null){
                            string[] parts = line.Split('|');

                            string type = parts[0].Trim();
                            string name = parts[1].Trim();
                            string desc = parts[2].Trim();

                            if(type == "SimpleGoal"){
                                int points = int.Parse(parts[3].Trim());
                                bool completed = bool.Parse(parts[4].Trim());

                                SimpleGoal goal = new SimpleGoal(name, desc, points, completed);
                                goals.Add(goal);
                            }
                            else if(type == "EternalGoal"){
                                int points = int.Parse(parts[3].Trim());

                                EternalGoal goal = new EternalGoal(name, desc, points);
                                goals.Add(goal);
                            }
                            else if(type == "ChecklistGoal"){
                                int amountCompleted = int.Parse(parts[3].Trim());
                                int amountNeeded = int.Parse(parts[4].Trim());
                                int points = int.Parse(parts[5].Trim());
                                int bonus = int.Parse(parts[6].Trim());

                                ChecklistGoal goal = new ChecklistGoal(name, desc, amountCompleted, amountNeeded, points, bonus);
                                goals.Add(goal);
                            }
                        }
                    }

                    Console.WriteLine("Goals loaded successfully.");
                }
                else{
                    Console.WriteLine("File not found.");
                }
            }
            else if(choice == 5){
                Console.WriteLine("Your goals are:");
                for(int i = 0; i < goals.Count; i++){
                    Console.Write($"{i + 1}. ");
                    goals[i].Display();
                }

                Console.Write("Which goal would you like to record: ");
                int goal = int.Parse(Console.ReadLine());
                goal = goal - 1;
                if(goal >= 0 && goal < goals.Count){
                    int increase = goals[goal].Progress();
                    total = total + increase;
                    Console.WriteLine($"\nYou gained {increase} points.");
                }
                else{
                    Console.WriteLine("Invalid Input");
                }
            }
            else if(choice == 6){
                break;
            }
            else{
                Console.WriteLine("Invalid input");
            }
        }
    }
    }