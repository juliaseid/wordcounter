using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public Word UserWord { get; set; }
    public Sentence UserSentence { get; set; }

    public RepeatCounter (Word userWord, Sentence userSentence)
    {
      UserWord = userWord;
      UserSentence = userSentence;
    }

    public int GetRepeatCount()
    {
      string [] sentence = UserSentence.SplitSentence(UserSentence.InputSentence);
      int instances = 0;
      for (int i = 0; i<sentence.Length; i++)
      {
        if (sentence[i] == UserWord.InputWord)
        {
          instances ++;
        }
      }

      return instances;
    }

  }

}