using System;

public class Reference{
    
    string _book;
    int _chapter;
    int _startVerse;
    int _endVerse;
    string _sepChar;

    public Reference(string book,int chapter,int start){
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = start;
    }
    public Reference(string book,int chapter,int start,int end){
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
        _sepChar = "-";
    }

    public string Return(){
        if(_startVerse == _endVerse){
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else{
            return $"{_book} {_chapter}:{_startVerse}{_sepChar}{_endVerse}";
        }
    }
}