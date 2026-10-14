using System;
using System.Collections.Generic;

public class Entry{
    public string _date;
    public string _prompt;
    public string _response;

    public void display() {
        Console.WriteLine($"Date: {_date} -- Prompt: {_prompt} \n {_response}\n");
    }
}