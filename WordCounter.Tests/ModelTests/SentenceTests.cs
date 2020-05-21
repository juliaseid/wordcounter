using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests 
{
  [TestClass]
  public class SentenceTests
  {
    [TestMethod]
    public void SentenceConstructor_ConstructsASentence_Sentence()
    {
      Sentence newSentence = new Sentence ("Bad Bunny isn't really a bunny.");
      Assert.AreEqual(typeof(Sentence), newSentence.GetType());
    }

    [TestMethod]
    public void FormatSentence_ToLowerCase_String()
    {
      //Arrange
      Sentence newSentence = new Sentence ("Bad Bunny isn't really a bunny.");
      //Act
      string result = newSentence.FormatSentence();
      //Assert
      Assert.AreEqual(result, "bad bunny isn't really a bunny.");
    }

    [TestMethod]
    public void SplitSentence_SplitOnSpaces_StringArray()
    {
      //Arrange
      Sentence newSentence = new Sentence ("Bad Bunny isn't really a bunny.");
      string [] target = new string [6] {"bad", "bunny", "isnt", "really", "a", "bunny"};
      //Act
      string [] result = newSentence.SplitSentence(newSentence.InputSentence);
      //Assert
      CollectionAssert.AreEqual(result, target);
    }

    [TestMethod]
    public void SplitSentence_RemoveNonAlphas_StringArray()
    {
      //Arrange
      Sentence newSentence = new Sentence ("Bad Bunny isn't really a bunny.");
      string [] target = new string [6] {"bad", "bunny", "isnt", "really", "a", "bunny"};
      //Act
      string [] result = newSentence.SplitSentence(newSentence.InputSentence);
      foreach(string word in result)
      {
        Console.WriteLine("word");
        Console.WriteLine(word);
      }
            //Assert
      CollectionAssert.AreEqual(result, target);
    }
  }
}