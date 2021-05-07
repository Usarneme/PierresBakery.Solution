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

    [TestMethod]
    public void Bread_GetPriceOfNineLoaves_Thirty()
    {
      int numberOfLoaves = 9;
      int expectedCost = 30;
      int returnedCost = Bread.GetPriceOfMultiple(numberOfLoaves);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Bread_GetPriceOfTenLoaves_ThirtyFive()
    {
      int numberOfLoaves = 10;
      int expectedCost = 35;
      int returnedCost = Bread.GetPriceOfMultiple(numberOfLoaves);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Bread_GetPriceOfElevenLoaves_ThirtyFive()
    {
      int numberOfLoaves = 11;
      int expectedCost = 40;
      int returnedCost = Bread.GetPriceOfMultiple(numberOfLoaves);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Bread_GetPriceOfTwelveLoaves_Forty()
    {
      int numberOfLoaves = 12;
      int expectedCost = 40;
      int returnedCost = Bread.GetPriceOfMultiple(numberOfLoaves);
      Assert.AreEqual(expectedCost, returnedCost);
    }

  }
}