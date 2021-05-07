using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryNamespace;
using System.Collections.Generic;
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
      int returnedCost = Bread.Price;
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

    [TestMethod]
    public void Pastry_GetPrice_Two()
    {
      int expectedCost = 2;
      int returnedCost = Pastry.Price;
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Pastry_GetPriceOfTwo_Four()
    {
      int numberOfPastries = 2;
      int expectedCost = 4;
      int returnedCost = Pastry.GetPriceOfMultiple(numberOfPastries);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Pastry_GetPriceOfThree_Five()
    {
      int numberOfPastries = 3;
      int expectedCost = 5;
      int returnedCost = Pastry.GetPriceOfMultiple(numberOfPastries);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Pastry_GetPriceOfFour_Seven()
    {
      int numberOfPastries = 4;
      int expectedCost = 7;
      int returnedCost = Pastry.GetPriceOfMultiple(numberOfPastries);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Pastry_GetPriceOfTen_Seventeen()
    {
      int numberOfPastries = 10;
      int expectedCost = 17;
      int returnedCost = Pastry.GetPriceOfMultiple(numberOfPastries);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void PierresBakery_CreateBakery_BakeryInstance()
    {
      PierresBakery myPierresBakery = new PierresBakery();
      Assert.AreEqual(typeof(PierresBakery), myPierresBakery.GetType());
    }

    [TestMethod]
    public void PierresBakery_NewBakeryOrderCost_Zero()
    {
      PierresBakery myPierresBakery = new PierresBakery();
      int expectedOrderCost = 0;
      int returnedOrderCost = myPierresBakery.GetCurrentOrderCost();
      Assert.AreEqual(expectedOrderCost, returnedOrderCost);
    }

    [TestMethod]
    public void PierresBakery_NewBakeryOrderItems_EmptyList()
    {
      PierresBakery myPierresBakery = new PierresBakery();
      Dictionary<string, int> returnedOrderListItems = myPierresBakery.GetCurrentOrderItems();
      Dictionary<string, int> expectedOrderItems = new Dictionary<string, int>()
      {
        {"Breads", 0}, {"Pastries", 0}
      };
      CollectionAssert.AreEqual(expectedOrderItems, returnedOrderListItems);
    }

    [TestMethod]
    public void PierresBakery_AddBreadToOrder_OneBreadInOrder()
    {
      PierresBakery myPierresBakery = new PierresBakery();
      myPierresBakery.AddBreadToCurrentOrder(new Bread());
      int expectedBreadNumber = 1;
      int returnedBreadNumber = myPierresBakery.GetCurrentOrderItems()["Breads"];
      Assert.AreEqual(expectedBreadNumber, returnedBreadNumber);
    }
  }
}
