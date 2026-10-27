using System;

public class Word{
    
    string _word;
    bool _isHidden;

    public Word(string input){
        _word = input;
        _isHidden = false;
    }

    public void SetWord(string word){
        _word = word;
    }
    public void Hide(){
        _isHidden = true;
    }
    public string Return(){
        if(_isHidden == true){
            return "_____";
        }
        else{
            return _word;
        }
    }
}