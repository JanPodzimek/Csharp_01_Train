namespace TrainTest;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Train;

[TestClass]
public class UnitTestBusinessWagon {
    [TestMethod]
    public void Test_BusinessWagonConstructor2Parameters() {
        Person p1 = new Person("Jan", "Novak");
        BusinessWagon w1 = new BusinessWagon(p1, 40);
        Assert.AreEqual(w1.Steward.FirstName, "Jan");
        Assert.AreEqual(w1.Steward.LastName, "Novak");
        Assert.AreEqual(w1.Sits.Count, 40);
    }
    [TestMethod]
    public void Test_BusinessWagonDefaultReservationSeatValue() {
        Person p1 = new Person("Jan", "Novak");
        BusinessWagon w1 = new BusinessWagon(p1, 30);
        Random rnd = new Random();
        int seat = rnd.Next(1, w1.NumberOfChairs);
        Assert.AreEqual(w1.Sits[seat].Reserved, false);
    }
    [TestMethod]
    public void Test_BusinessWagonToString() {
        Person p1 = new Person("Jan", "Novak");
        BusinessWagon w1 = new BusinessWagon(p1, 30);
        Assert.AreEqual(w1.ToString(), "BusinessWagon: number of seats: 30, " +
            "steward: Jan Novak");
    }
}


