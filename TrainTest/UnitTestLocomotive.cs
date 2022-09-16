namespace TrainTest;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Train;

[TestClass]
public class UnitTestLocomotive {

    [TestMethod]
    public void Test_LocomotiveConstructorNoParameter() {
        Locomotive l1 = new Locomotive();
        Assert.AreEqual(l1.Person.FirstName, "unknown");
        Assert.AreEqual(l1.Person.LastName, "unknown");
        Assert.AreEqual(l1.Engine.EngineType == engineType.unknow, true);
    }
    [TestMethod]
    public void Test_LocomotiveConstructor2Parameters() {
        Person p1 = new Person("Jiri", "Chrapek");
        Engine e1 = new Engine(engineType.steam);
        Locomotive l1 = new Locomotive(p1, e1);
        Assert.AreEqual(l1.Person.FirstName, "Jiri");
        Assert.AreEqual(l1.Person.LastName, "Chrapek");
        Assert.AreEqual(l1.Engine.EngineType == engineType.steam, true);
    }
    [TestMethod]
    public void Test_LocomotiveToString() {
        Person p1 = new Person("Jiri", "Chrapek");
        Engine e1 = new Engine(engineType.steam);
        Locomotive l1 = new Locomotive(p1, e1);
        Assert.AreEqual(l1.ToString(), "Locomotive: engine > steam, driver: Jiri Chrapek");
    }
}


