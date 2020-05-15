using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public Sentence InputSentence { get; set; }

    public RepeatCounter (Sentence inputSentence)
    {
      InputSentence = inputSentence;
    }

  }

}