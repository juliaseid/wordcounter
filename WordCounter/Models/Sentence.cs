using System;
using System.Collections.Generic;

namespace Scrabble.Models
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

 
  }

}
