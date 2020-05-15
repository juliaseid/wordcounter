using System;
using System.Collections.Generic;
using System.Linq;

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
          else
          {
            word=word;
          }
        }
        splitSentence[i] = word;
      }
      return splitSentence;
    }


  }

}
