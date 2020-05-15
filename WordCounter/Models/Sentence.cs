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
      string word = InputWord.ToLower();
      
      return word;
    }

  }

}
