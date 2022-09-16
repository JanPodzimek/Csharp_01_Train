namespace TrainTest;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Train;

[TestClass]
public class UnitTestEconomyWagon {

    [TestMethod]
    public void Test_EconomyWagonConstructor1Parameter() {
        EconomyWagon w1 = new EconomyWagon(15);
        Assert.AreEqual(w1.Sits.Count, 15);
    }
    [TestMethod]
    public void Test_EconomyWagonToString() {
        EconomyWagon w1 = new EconomyWagon(15);
        Assert.AreEqual(w1.ToString(), "EconomyWagon: number of seats: 15");
    }
}

