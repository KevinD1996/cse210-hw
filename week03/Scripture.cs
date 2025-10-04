public class Scripture

{
using System;
using System.Collections.Generic;


{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] tokens = text.Split(' ');
        foreach (string token in tokens)
        {
            _words.Add(new Word(token));
        }
    }

  
    public void HideRandomWords(int numberToHide)
    {
        List<int> candidates = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
                candidates.Add(i);
        }

        for (int i = 0; i < numberToHide && candidates.Count > 0; i++)
        {
            int index = _random.Next(candidates.Count);
            _words[candidates[index]].Hide();
            candidates.RemoveAt(index);
        }
    }

   
    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + ": ";
        foreach (Word w in _words)
        {
            result += w.GetDisplayText() + " ";
        }
        return result.Trim();
    }

    
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
}
}