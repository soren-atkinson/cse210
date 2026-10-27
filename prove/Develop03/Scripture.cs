using System;
using System.Collections.Generic;


public class Scripture{

    List<Word> _verses = new List<Word>();
    Reference _reference;
    Random random = new Random();

    public Scripture(List<Word> verse,Reference reference){
        _verses = verse;
        _reference = reference;
    }

    public void Display(){
        Console.Clear();
        Console.Write(_reference.Return());
        foreach(Word word in _verses){
            Console.Write($" {word.Return()}");
        }
    }
    public void Hide(){
    List<int> visibleWords = new List<int>();

    for (int i = 0; i < _verses.Count; i++)
    {
        if (_verses[i].Return() != "_____")
        {
            visibleWords.Add(i);
        }
    }
    if (visibleWords.Count > 0)
    {
        int randomNumber = random.Next(visibleWords.Count);
        _verses[visibleWords[randomNumber]].Hide();
    }
    }
    public bool IsCompletelyHidden(){
        foreach (Word word in _verses){
        if (word.Return() != "_____"){
        return false;
        }
        }
        return true;
        }

}