using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests 
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void GetRepeatCount_CountsRepeatsOfSpecifiedWord_Int()
    {
      //Arrange
      Sentence newSentence = new Sentence ("Bad Bunny isn't really a bunny.");
      Word newWord = new Word ("bunny");
      RepeatCounter newCounter = new RepeatCounter(newWord, newSentence);
      //Act
      int result = newCounter.GetRepeatCount();
      //Assert
      Assert.AreEqual(result, 2);
    }
  }
}