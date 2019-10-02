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
      Find newFind = new Find("hello world", "world");
      Replace newSent = new Replace(newFind, "Stephen");
      // Act
      string result = newSent.NewPhrase();
      // Assert
      Assert.AreEqual("hello Stephen", result);
    }
  }
}