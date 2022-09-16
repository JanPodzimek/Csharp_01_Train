namespace TrainTest;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Train;

[TestClass]
public class UnitTestHopper {
    [TestMethod]
    public void Test_HopperConstructor1Parameter() {
        Hopper w1 = new Hopper(30.3);
        Assert.AreEqual(w1.Tonnage, 30.3);
        Hopper w2 = new Hopper(-2);
        Assert.AreEqual(w2.Tonnage, 0);
    }
    [TestMethod]
    public void Test_HopperToString() {
        Hopper w1 = new Hopper(30.3);
        Assert.AreEqual(w1.ToString(), "Hopper");
    }
}


