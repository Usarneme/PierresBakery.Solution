using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryNamespace;
using System;
using System.Collections.Generic;
namespace PierresBakeryTesting
{
  [TestClass]
  public class PierresBakeryTests : IDisposable
  {
    string PASTRY = "Pastries";
    string BREAD = "Breads";

    public void Dispose()
    {
      PierresBakery.ClearOrder();
    }

    [TestMethod]
    public void Bread_GetBasePriceOfOneLoaf_Five()
    {
      // Arrange, Act, Assert
      int expectedCost = 5;
      int returnedCost = Bread.Price;
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Bread_GetPriceOfZeroLoaves_Zero()
    {
      int numberOfLoaves = 0;
      int expectedCost = 0;
      int returnedCost = Bread.CalculatePrice(numberOfLoaves);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Bread_GetPriceOfOneLoaf_Five()
    {
      int numberOfLoaves = 1;
      int expectedCost = 5;
      int returnedCost = Bread.CalculatePrice(numberOfLoaves);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Bread_GetPriceOfThreeLoaves_Ten()
    {
      int numberOfLoaves = 3;
      int expectedCost = 10;
      int returnedCost = Bread.CalculatePrice(numberOfLoaves);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Bread_GetPriceOfNineLoaves_Thirty()
    {
      int numberOfLoaves = 9;
      int expectedCost = 30;
      int returnedCost = Bread.CalculatePrice(numberOfLoaves);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Bread_GetPriceOfTenLoaves_ThirtyFive()
    {
      int numberOfLoaves = 10;
      int expectedCost = 35;
      int returnedCost = Bread.CalculatePrice(numberOfLoaves);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Bread_GetPriceOfElevenLoaves_ThirtyFive()
    {
      int numberOfLoaves = 11;
      int expectedCost = 40;
      int returnedCost = Bread.CalculatePrice(numberOfLoaves);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Bread_GetPriceOfTwelveLoaves_Forty()
    {
      int numberOfLoaves = 12;
      int expectedCost = 40;
      int returnedCost = Bread.CalculatePrice(numberOfLoaves);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Pastry_GetBasePriceOfOnePastry_Two()
    {
      int expectedCost = 2;
      int returnedCost = Pastry.Price;
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Pastry_GetPriceOfZero_Zero()
    {
      int numberOfPastries = 0;
      int expectedCost = 0;
      int returnedCost = Pastry.CalculatePrice(numberOfPastries);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Pastry_GetPriceOfOne_Two()
    {
      int numberOfPastries = 1;
      int expectedCost = 2;
      int returnedCost = Pastry.CalculatePrice(numberOfPastries);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Pastry_GetPriceOfTwo_Four()
    {
      int numberOfPastries = 2;
      int expectedCost = 4;
      int returnedCost = Pastry.CalculatePrice(numberOfPastries);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Pastry_GetPriceOfThree_Five()
    {
      int numberOfPastries = 3;
      int expectedCost = 5;
      int returnedCost = Pastry.CalculatePrice(numberOfPastries);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Pastry_GetPriceOfFour_Seven()
    {
      int numberOfPastries = 4;
      int expectedCost = 7;
      int returnedCost = Pastry.CalculatePrice(numberOfPastries);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void Pastry_GetPriceOfTen_Seventeen()
    {
      int numberOfPastries = 10;
      int expectedCost = 17;
      int returnedCost = Pastry.CalculatePrice(numberOfPastries);
      Assert.AreEqual(expectedCost, returnedCost);
    }

    [TestMethod]
    public void PierresBakery_NewBakeryOrderCost_Zero()
    {
      int expectedOrderCost = 0;
      int returnedOrderCost = PierresBakery.GetCurrentOrderCost();
      Assert.AreEqual(expectedOrderCost, returnedOrderCost);
    }

    [TestMethod]
    public void PierresBakery_NewBakeryOrderItems_EmptyList()
    {
      Dictionary<string, int> returnedOrderListItems = PierresBakery.GetCurrentOrderItems();
      Dictionary<string, int> expectedOrderItems = new Dictionary<string, int>()
      {
        {"Breads", 0}, {"Pastries", 0}
      };
      CollectionAssert.AreEqual(expectedOrderItems, returnedOrderListItems);
    }

    [TestMethod]
    public void PierresBakery_AddBreadToOrder_OneBreadInOrder()
    {
      int numberOfBreadsToAddToOrder = 1;
      PierresBakery.AddToCurrentOrder(BREAD, numberOfBreadsToAddToOrder);
      int expectedBreadNumber = 1;
      int returnedBreadNumber = PierresBakery.GetCurrentOrderItems()["Breads"];
      Assert.AreEqual(expectedBreadNumber, returnedBreadNumber);
    }

    [TestMethod]
    public void PierresBakery_AddFiveBreadsToOrder_FiveBreadsInOrder()
    {
      int numberOfBreadsToAddToOrder = 5;
      PierresBakery.AddToCurrentOrder(BREAD, numberOfBreadsToAddToOrder);
      int expectedBreadNumber = 5;
      int returnedBreadNumber = PierresBakery.GetCurrentOrderItems()["Breads"];
      Assert.AreEqual(expectedBreadNumber, returnedBreadNumber);
    }

    [TestMethod]
    public void PierresBakery_AddPastryToOrder_OnePastryInOrder()
    {
      int numberOfPastriesToAddToOrder = 1;
      PierresBakery.AddToCurrentOrder(PASTRY, numberOfPastriesToAddToOrder);
      int expectedPastryNumber = 1;
      int returnedPastryNumber = PierresBakery.GetCurrentOrderItems()["Pastries"];
      Assert.AreEqual(expectedPastryNumber, returnedPastryNumber);
    }

    [TestMethod]
    public void PierresBakery_AddFivePastriesToOrder_FivePastriesInOrder()
    {
      int numberOfPastriesToAddToOrder = 5;
      PierresBakery.AddToCurrentOrder(PASTRY, numberOfPastriesToAddToOrder);
      int expectedPastryNumber = 5;
      int returnedPastryNumber = PierresBakery.GetCurrentOrderItems()["Pastries"];
      Assert.AreEqual(expectedPastryNumber, returnedPastryNumber);
    }

    [TestMethod]
    public void PierresBakery_AddBreadToOrder_CostIsFiveDollars()
    {
      PierresBakery.AddToCurrentOrder(BREAD, 1);
      int expectedCostOfOrder = 5;
      int returnedCostOfOrder = PierresBakery.GetCurrentOrderCost();
      Assert.AreEqual(expectedCostOfOrder, returnedCostOfOrder);
    }

    [TestMethod]
    public void PierresBakery_AddPastryToOrder_CostIsTwoDollars()
    {
      PierresBakery.AddToCurrentOrder(PASTRY, 1);
      int expectedCostOfOrder = 2;
      int returnedCostOfOrder = PierresBakery.GetCurrentOrderCost();
      Assert.AreEqual(expectedCostOfOrder, returnedCostOfOrder);
    }

    [TestMethod]
    public void PierresBakery_AddTenBreadToOrder_CostIsThirtyFiveDollars()
    {
      PierresBakery.AddToCurrentOrder(BREAD, 10);
      int expectedCostOfOrder = 35;
      int returnedCostOfOrder = PierresBakery.GetCurrentOrderCost();
      Assert.AreEqual(expectedCostOfOrder, returnedCostOfOrder);
    }

    [TestMethod]
    public void PierresBakery_AddTenPastriesToOrder_CostIsSeventeenDollars()
    {
      PierresBakery.AddToCurrentOrder(PASTRY, 10);
      int expectedCostOfOrder = 17;
      int returnedCostOfOrder = PierresBakery.GetCurrentOrderCost();
      Assert.AreEqual(expectedCostOfOrder, returnedCostOfOrder);
    }

    [TestMethod]
    public void PierresBakery_AddTenPastriesAndTenBreadToOrder_CostIsFiftyTwoDollars()
    {
      PierresBakery.AddToCurrentOrder(BREAD, 10);
      PierresBakery.AddToCurrentOrder(PASTRY, 10);
      int expectedCostOfOrder = 52;
      int returnedCostOfOrder = PierresBakery.GetCurrentOrderCost();
      Assert.AreEqual(expectedCostOfOrder, returnedCostOfOrder);
    }

  }
}
