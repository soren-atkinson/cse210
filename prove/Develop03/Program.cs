using System;
using System.Collections.Generic;


class Program
{
static void Main(string[] args)
{
    Reference reference = new Reference("Proverbs", 3, 5, 6);
    string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct your paths.";
    string[] words = text.Split(' ');
    List<Word> verse = new List<Word>();

    foreach (string word in words)
    {
        verse.Add(new Word(word));
    }

    Scripture scripture = new Scripture(verse, reference);

    string input = "";
    while (input != "quit")
    {
        Console.Clear();
        scripture.Display();
        if(scripture.IsCompletelyHidden()){
            break;
        }
        Console.WriteLine("\n\nPress Enter to Continue or type quit to finish:");
        input = Console.ReadLine();
        if (input != "quit")
        {
            scripture.Hide();
        }
    }
}

}