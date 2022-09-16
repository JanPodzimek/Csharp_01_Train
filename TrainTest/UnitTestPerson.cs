namespace TrainTest;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Train;

[TestClass]
public class UnitTestPerson{

    [TestMethod]
    public void Test_PersonConstructor2Parameters(){
        Person p1 = new Person("Karel", "Vevoda");
        Assert.AreEqual(p1.FirstName, "Karel");
        Assert.AreEqual(p1.LastName, "Vevoda");
    }
    [TestMethod]
    public void Test_PersonConstructorNoParameters() {
        Person p1 = new Person();
        Assert.AreEqual(p1.FirstName, "unknown");
        Assert.AreEqual(p1.LastName, "unknown");
    }
    [TestMethod]
    public void Test_PersonConstructor2ParametersToString() {
        Person p1 = new Person("Karel", "Vevoda");
        Assert.AreEqual(p1.ToString(), "Karel Vevoda");
    }
    [TestMethod]
    public void Test_PersonConstructorNoParametersToString() {
        Person p1 = new Person();
        Assert.AreEqual(p1.ToString(), "unknown unknown");
    }
}
