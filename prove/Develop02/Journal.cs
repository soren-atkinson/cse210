using System;
using System.Collections.Generic;
using System.IO; 

public class Journal{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts = new List<string>();
    Random random = new Random();
    public void addEntry(){
        int randomNumber = random.Next(_prompts.Count);
        
        Entry entry1 = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        entry1._date = theCurrentTime.ToShortDateString();
        entry1._prompt = _prompts[randomNumber];
        Console.WriteLine(entry1._prompt);
        entry1._response = Console.ReadLine();
        _entries.Add(entry1);
    }
    public void displayEntries(){
        foreach(Entry entry in _entries){
            entry.display();
        }
    }
    public void save(string file){
        string filename = file;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries){
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }
    public void load(string file){
        string filename = file;
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            _entries.Add(entry);
        }
    }
    public void addPrompt(){
        Console.Write("Prompt: ");
        Console.ReadLine();
        _prompts.Add(Console.ReadLine());
    }
}