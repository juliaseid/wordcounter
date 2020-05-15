using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Sentence
  {
    public string InputWord { get; set; }
    public string InputSentence { get; set; }

    public Sentence (string inputWord, string inputSentence )
    {
      InputWord = inputWord;
      InputSentence = inputSentence;
    }

    public string FormatWord()
    {
      string word = InputWord.Trim().ToLower();
      for (int i=0; i<word.Length; i++)
      {
        if (Char.IsLetter(word, i)==false)
        {
          word = word.Remove(i, 1);
        }
      }
      return word;
    }

    public string FormatSentence()
    {
      string sentence = InputSentence.ToLower();
      return sentence;
    }


  }

}
