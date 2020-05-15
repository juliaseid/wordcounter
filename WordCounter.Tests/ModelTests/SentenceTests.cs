using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests 
{
  [TestClass]
  public class SentenceTests
  {
    [TestMethod]
    public void FormatWord_ToLowerCase_String()
    {
      //Arrange
      Sentence newSentence = new Sentence("Bunny", "Bad Bunny isn't really a bunny.");
      //Act
      string result = newSentence.FormatWord();
      //Assert
      Assert.AreEqual(result, "bunny");
    }

    [TestMethod]
    public void FormatWord_RemoveWhitespace_String()
    {
      //Arrange
      Sentence newSentence = new Sentence("Bunny ", "Bad Bunny isn't really a bunny.");
      //Act
      string result = newSentence.FormatWord();
      //Assert
      Assert.AreEqual(result, "bunny");
    }

    [TestMethod]
    public void FormatWord_RejectNonAlpha_String()
    {
      //Arrange
      Sentence newSentence = new Sentence("Bu nny2", "Bad Bunny isn't really a bunny.");
      //Act
      string result = newSentence.FormatWord();
      //Assert
      Assert.AreEqual(result, "bunny");
    }
  }
}