namespace TrainTest;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Train;

[TestClass]
public class UnitTestEngine {

    [TestMethod]
    public void Test_EngineConstructor1Parameter() {
        Engine e1 = new Engine(engineType.steam);
        Assert.AreEqual(e1.EngineType == engineType.steam, true);
    }
    [TestMethod]
    public void Test_EngineToString() {
        Engine e1 = new Engine(engineType.electric);
        Assert.AreEqual(e1.ToString(), "electric");
        Assert.AreNotEqual(e1.ToString(), "diesel");
    }

}