using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests 
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordConstructor_ConstructsAWord_Word()
    {
      Word newWord = new Word ("bunny");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void FormatWord_ToLowerCase_String()
    {
      //Arrange
      Word newWord = new Word("Bunny");
      //Act
      string result = newWord.FormatWord();
      //Assert
      Assert.AreEqual(result, "bunny");
    }

    [TestMethod]
    public void FormatWord_RemoveWhitespace_String()
    {
      //Arrange
      Word newWord = new Word("Bunny ");
      //Act
      string result = newWord.FormatWord();
      //Assert
      Assert.AreEqual(result, "bunny");
    }

    [TestMethod]
    public void FormatWord_RejectNonAlpha_String()
    {
      //Arrange
      Word newWord = new Word("Bu nny2");
      //Act
      string result = newWord.FormatWord();
      //Assert
      Assert.AreEqual(result, "bunny");
    }

  }
}