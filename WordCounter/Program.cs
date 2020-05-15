using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace Program
{
  class ParseSentence
  {
    static void Main()
    {
      // string sentence;
      // string word;
      // Sentence userSentence = new Sentence(sentence);
      // Word userWord = new Word(word);
      Sentence userSentence = new Sentence("");
      Word userWord = new Word("");
      string response = "n";
      while (response == "n") 
      {
        Console.WriteLine("Please enter a sentence.");
        string sentence = Console.ReadLine();
        userSentence = new Sentence(sentence);
        Console.WriteLine("We've taken your sentence and removed non-alphabetic characters and capitals for easier comparison:");
        foreach(string splitWord in userSentence.SplitSentence(sentence))
        {
          Console.WriteLine(splitWord);
        }
        Console.WriteLine("Did we get it right? [Y]es or [N]o?");
        response = Console.ReadLine().ToLower();
      }
      if (response == "y")
      {
        string wordResponse = "n";

        while (wordResponse == "n")
          {
          Console.WriteLine("Please enter a word to search for.");
          string word = Console.ReadLine();
          userWord = new Word(word);
          Console.WriteLine("Your word without capitals is " + userWord.FormatWord() + ", right? [Y]es/[N]o");
          wordResponse = Console.ReadLine().ToLower();
          }
        if (wordResponse == "y")
        {
          RepeatCounter countEmUp = new RepeatCounter(userWord, userSentence);
          Console.WriteLine("The word " + userWord.InputWord + " appears " + countEmUp.GetRepeatCount() + " times in your sentence.");
        }
      }
    }
  }
}