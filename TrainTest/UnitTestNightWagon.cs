namespace TrainTest;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Train;

[TestClass]
public class UnitTestNightWagon {
    [TestMethod]
    public void Test_NightWagonConstructor2Parameters(){
        NightWagon w1 = new NightWagon(30, 20);
        Assert.AreEqual(w1.Beds.Count, 20);
        Assert.AreEqual(w1.Sits.Count, 30);
    }
    [TestMethod]
    public void Test_NightWagonToString(){
        NightWagon w1 = new NightWagon(30, 20);
        Assert.AreEqual(w1.ToString(), "NightWagon: number of seats: 30, " +
                                       "number of beds: 20");
    }
}