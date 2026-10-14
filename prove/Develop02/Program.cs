using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        List<string> prompts = new List<string>
        {
            "What was the best part of your day?",
            "What is something you learned today?",
            "Who did you help today?",
            "What made you laugh today?",
            "What is something you want to improve?"
        };
        journal._prompts = prompts;
        int choice = 0;
        while (choice != 5){
            Console.Write(@"
Please select one of the following choices:
1. Write
2: Display
3: Load
4: Save
5: Quit
What would you lIke to do: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1) {
                journal.addEntry();
            }
            else if (choice == 2){
                journal.displayEntries();            }
            else if (choice == 3){
                Console.Write("File Name:");
                string file = Console.ReadLine();
                journal.load(file);
            }
            else if (choice == 4){
                Console.Write("File Name:");
                string file = Console.ReadLine();
                journal.save(file);
            }
            else if (choice == 5){
                break;
            }
            else{
                Console.WriteLine("Error Try Again");
            }
        }
    }
}