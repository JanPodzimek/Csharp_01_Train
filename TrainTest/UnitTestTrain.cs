namespace TrainTest;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Train;

[TestClass]
public class UnitTestTrain {
    [TestMethod]
    public void Test_TrainConstructorNoParameter() {
        Train t1 = new Train();
        Assert.AreEqual(t1.TrainNumber, 1);
        Assert.AreEqual(t1.Wagons.Count, 0);
        Assert.AreEqual(t1.Locomotive.Engine.EngineType, engineType.unknow);
        Assert.AreEqual(t1.Locomotive.Person.FirstName, "unknown");
        Assert.AreEqual(t1.Locomotive.Person.LastName, "unknown");
    }
    [TestMethod]
    public void Test_TrainConstructor1Parameter() {
        Locomotive l1 = new Locomotive(new Person("Karel", "Jebavy"),
            new Engine(engineType.diesel));
        Train t1 = new Train(l1);
        Assert.AreEqual(t1.TrainNumber, 2);
        Assert.AreEqual(t1.Wagons.Count, 0);
        Assert.AreEqual(t1.Locomotive.Engine.EngineType, engineType.diesel);
        Assert.AreEqual(t1.Locomotive.Person.FirstName, "Karel");
        Assert.AreEqual(t1.Locomotive.Person.LastName, "Jebavy");
    }
    [TestMethod]
    public void Test_TrainConstructor2Parameters() {
        Locomotive l1 = new Locomotive(new Person("Karel", "Jebavy"),
            new Engine(engineType.diesel));
        Person steward = new Person("Lenka", "Kozakova");
        BusinessWagon w1 = new BusinessWagon(steward, 50);
        EconomyWagon w2 = new EconomyWagon(60);
        EconomyWagon w3 = new EconomyWagon(60);
        NightWagon w4 = new NightWagon(30, 20);
        List<Wagon> wagons = new List<Wagon> { w1, w2, w3, w4 };
        Train t1 = new Train(l1, wagons);
        Assert.AreEqual(t1.TrainNumber, 3);
        Assert.AreEqual(t1.Wagons.Count, 4);
        Assert.AreEqual(t1.Locomotive.Engine.EngineType, engineType.diesel);
        Assert.AreEqual(t1.Locomotive.Person.FirstName, "Karel");
        Assert.AreEqual(t1.Locomotive.Person.LastName, "Jebavy");
    }
}
