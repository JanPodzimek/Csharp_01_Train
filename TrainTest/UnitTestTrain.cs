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
        Locomotive l1 = new Locomotive(new Person("Karel", "Novak"),
                new Engine(engineType.diesel));
        Train t1 = new Train(l1);
        Assert.AreEqual(t1.TrainNumber, 2);
        Assert.AreEqual(t1.Wagons.Count, 0);
        Assert.AreEqual(t1.Locomotive.Engine.EngineType, engineType.diesel);
        Assert.AreEqual(t1.Locomotive.Person.FirstName, "Karel");
        Assert.AreEqual(t1.Locomotive.Person.LastName, "Novak");
    }
    [TestMethod]
    public void Test_TrainConstructor2Parameters() {
        Locomotive l1 = new Locomotive(new Person("Karel", "Novak"),
            new Engine(engineType.diesel));
        Person steward = new Person("Lenka", "Novotna");
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
        Assert.AreEqual(t1.Locomotive.Person.LastName, "Novak");
    }
    [TestMethod]
    public void Test_TrainConnectWagon() {
        Locomotive l1 = new Locomotive(new Person("Karel", "Novak"),
            new Engine(engineType.diesel));
        Person steward = new Person("Lenka", "Novotna");
        BusinessWagon w1 = new BusinessWagon(steward, 50);
        EconomyWagon w2 = new EconomyWagon(60);
        EconomyWagon w3 = new EconomyWagon(60);
        NightWagon w4 = new NightWagon(30, 20);
        Train t1 = new Train(l1);
        t1.ConnectWagon(w1);
        Assert.AreEqual(t1.Wagons.Count, 1);
        t1.ConnectWagon(w3);
        Assert.AreEqual(t1.Wagons.Count, 2);
        t1.ConnectWagon(w2);
        Assert.AreEqual(t1.Wagons.Count, 3);
    }
    [TestMethod]
    public void Test_TrainDisconnectWagon() {
        Locomotive l1 = new Locomotive(new Person("Karel", "Novak"),
            new Engine(engineType.diesel));
        Person steward = new Person("Lenka", "Novotna");
        BusinessWagon w1 = new BusinessWagon(steward, 50);
        EconomyWagon w2 = new EconomyWagon(60);
        EconomyWagon w3 = new EconomyWagon(60);
        NightWagon w4 = new NightWagon(30, 20);
        List<Wagon> wagons = new List<Wagon> { w1, w2, w3, w4 };
        Train t1 = new Train(l1, wagons);
        t1.DisconnectWagon(w2);
        Assert.AreEqual(t1.Wagons.Count, 3);
        t1.DisconnectWagon(w2);
        Assert.AreEqual(t1.Wagons.Count, 3);
    }
    [TestMethod]
    public void Test_TrainReserveSeat() {
        Locomotive l1 = new Locomotive(new Person("Karel", "Novak"),
            new Engine(engineType.diesel));
        Person steward = new Person("Lenka", "Novotna");
        BusinessWagon w1 = new BusinessWagon(steward, 50);
        List<Wagon> wagons = new List<Wagon> { w1 };
        Train t1 = new Train(l1, wagons);
        Assert.AreEqual(t1.Wagons[0], w1);
        Assert.AreEqual(w1.Sits[12].Reserved, false);
        t1.reserveSeat(1, 12);
        Assert.AreEqual(w1.Sits[11].Reserved, true);
    }
    [TestMethod]
    public void Test_TrainCancelSeatReservation() {
        Locomotive l1 = new Locomotive(new Person("Karel", "Novak"),
            new Engine(engineType.diesel));
        Person steward = new Person("Lenka", "Novotna");
        BusinessWagon w1 = new BusinessWagon(steward, 50);
        List<Wagon> wagons = new List<Wagon> { w1 };
        Train t1 = new Train(l1, wagons);
        Assert.AreEqual(t1.Wagons[0], w1);
        Assert.AreEqual(w1.Sits[12 - 1].Reserved, false);
        t1.reserveSeat(1, 12);
        Assert.AreEqual(w1.Sits[12 - 1].Reserved, true);
        t1.cancelSeatReservation(1, 12);
        Assert.AreEqual(w1.Sits[12 - 1].Reserved, false);
    }
    [TestMethod]
    public void Test_TrainReserveBed() {
        Locomotive l1 = new Locomotive(new Person("Karel", "Novak"),
            new Engine(engineType.diesel));
        NightWagon w1 = new NightWagon(30, 20);
        List<Wagon> wagons = new List<Wagon> { w1 };
        Train t1 = new Train(l1, wagons);
        Assert.AreEqual(t1.Wagons[0], w1);
        Assert.AreEqual(w1.Beds[12 - 1].Reserved, false);
        t1.reserveBed(1, 12);
        Assert.AreEqual(w1.Beds[12 - 1].Reserved, true);
    }
    [TestMethod]
    public void Test_TrainCancelBedReservation() {
        Locomotive l1 = new Locomotive(new Person("Karel", "Novak"),
            new Engine(engineType.diesel));
        NightWagon w1 = new NightWagon(30, 20);
        List<Wagon> wagons = new List<Wagon> { w1 };
        Train t1 = new Train(l1, wagons);
        Assert.AreEqual(t1.Wagons[0], w1);
        Assert.AreEqual(w1.Beds[12 - 1].Reserved, false);
        t1.reserveBed(1, 12);
        Assert.AreEqual(w1.Beds[12 - 1].Reserved, true);
        t1.cancelBedReservation(1, 12);
        Assert.AreEqual(w1.Beds[12 - 1].Reserved, false);
    }
}
