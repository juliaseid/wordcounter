using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
  public class Sentence
  {
    public string InputSentence { get; set; }

    public Sentence (string inputSentence )
    {
      InputSentence = inputSentence;
    }

    public string FormatSentence()
    {
      string sentence = InputSentence.ToLower();
      return sentence;
    }

    public string [] SplitSentence(string sentence)
    {
      sentence = InputSentence.ToLower();
      string [] splitSentence = sentence.Split(' ');
      for (int i = 0; i<splitSentence.Length; i++) 
      {
        string word = splitSentence[i];
        for (int j=0; j<word.Length; j++)
        {
          if (Char.IsLetter(word, j)==false)
          {
            word = word.Remove(j, 1);
          }
        }
        splitSentence[i] = word;
      }
      return splitSentence;
    }

  }

}
