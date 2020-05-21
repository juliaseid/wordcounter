using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests 
{
  [TestClass]
  public class RepeatCounterTests
  {

    [TestMethod]
    public void RepeatCounterConstructor_CreatesInstanceOfRepeatCounter_RepeatCounter()
    {
      //Arrange
      Sentence newSentence = new Sentence ("Bad Bunny isn't really a bunny.");
      Word newWord = new Word ("bunny");
      RepeatCounter newCounter = new RepeatCounter(newWord, newSentence);
      Assert.AreEqual(typeof(RepeatCounter), newCounter.GetType());
    }


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