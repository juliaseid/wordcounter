using System;

namespace WordCounter.Models
{
  public class Word
  {
    public string InputWord { get; set; }

    public Word (string inputWord)
    {
      InputWord = inputWord;
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

  }

}
