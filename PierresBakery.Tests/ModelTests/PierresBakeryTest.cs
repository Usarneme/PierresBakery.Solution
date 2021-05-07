using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryNamespace;

namespace PierresBakeryTesting
{
  [TestClass]
  public class PierresBakeryTests
  {
    [TestMethod]
    public void Bread_GetPrice_Five()
    {
      // Arrange, Act, Assert
      int expectedCost = 5;
      int returnedCost = Bread.GetPrice();
      Assert.AreEqual(expectedCost, returnedCost);
    }
  }
}