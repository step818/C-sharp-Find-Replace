using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace.Models;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class FindTests
  {
    [TestMethod]
    public void ThisWord_ContainsWord_Bool()
    {
      // Arrange
      Find newFind = new Find("hello world", "world");
      // Act
      bool result = newFind.ThisWord();
      // Assert
      Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void NumberOfTimes_WordInStringArray_Int()
    {
      // Arrange
      Find newFind = new Find("pee pee caca poop poo poop pee ca poop", "poo");
      // Act
      int result = newFind.NumberOfTimes();
      // Assert
      Assert.AreEqual(4, result);
    } 
  }
}