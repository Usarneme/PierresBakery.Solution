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

    [TestMethod]
    public void Bread_GetPriceOfThreeLoaves_Ten()
    {
      int numberOfLoaves = 3;
      int expectedCost = 10;
      int returnedCost = Bread.GetPriceOfMultiple(numberOfLoaves);
      Assert.AreEqual(expectedCost, returnedCost);
    }
  }
}