using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace.Models;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class ReplaceTests
  {
    [TestMethod]
    public void NewPhrase_ReturnsNewText_Str()
    {
      // Arrange
      Find newFind = new Find("poop poo cat cathedral", "cat");
      Replace newSent = new Replace(newFind, "dog");
      // Act
      string result = newSent.NewPhrase();
      // Assert
      Assert.AreEqual("poop poo dog doghedral", result);
    }
    [TestMethod]
    public void NewPhrase_ReturnsAnotherNewText_Str()
    {
      Find newFind = new Find("you look like you're really enjoying yourself", "you");
      Replace newSent = new Replace(newFind, "I");
      string result = newSent.NewPhrase();
      Assert.AreEqual("I look like I're really enjoying Irself", result);
    }
  }
}