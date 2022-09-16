namespace Train;
public class Program {
    public static void Main(string[] args) {
        Person strojvedouci1 = new Person("Karel", "Novak");
        Person steward = new Person("Lenka", "Kozakova");
        Engine e1 = new Engine(engineType.steam);
        Locomotive locomotive1 = new Locomotive(strojvedouci1, e1);
        BusinessWagon w1 = new BusinessWagon(steward, 50);
        EconomyWagon w2 = new EconomyWagon(60);
        EconomyWagon w3 = new EconomyWagon(60);
        NightWagon w4 = new NightWagon(30, 20);
        Hopper w5 = new Hopper(12.5);
        Hopper w6 = new Hopper(14.3);
        Train train1 = new Train(locomotive1);

        Person strojvedouci2 = new Person("Jiri", "Mazlavy");
        Engine e2 = new Engine(engineType.diesel);
        Locomotive locomotive2 = new Locomotive(strojvedouci2, e2);
        EconomyWagon w7 = new EconomyWagon(40);
        EconomyWagon w8 = new EconomyWagon(40);
        NightWagon w9 = new NightWagon(30, 15);
        Hopper w10 = new Hopper(9.4);
        Hopper w11 = new Hopper(11.1);
        Train train2 = new Train(locomotive2);

        train1.ConnectWagon(w1);
        train1.ConnectWagon(w2);
        train1.ConnectWagon(w3);
        train1.ConnectWagon(w4);
        train1.ConnectWagon(w5);
        train1.ConnectWagon(w6);
        
        Console.WriteLine();
        train1.reserveSeat(2, 34);
        train1.reserveSeat(2, 34);
        train1.reserveSeat(5, 50);
        train1.cancelSeatReservation(2, 34);
        train1.cancelSeatReservation(2, 34);
        train1.cancelSeatReservation(2, 90);
        train1.cancelSeatReservation(0, 34);

        Console.WriteLine();
        train1.reserveBed(4, 19);
        train1.reserveBed(4, 19);
        train1.cancelBedReservation(4, 19);
        train1.cancelBedReservation(4, 19);
        train1.cancelBedReservation(2, 19);

        Console.WriteLine();
        train1.listReservedSeats();

        Console.WriteLine();
        train1.DisconnectWagon(w3);
        train1.DisconnectWagon(w5);
        train1.DisconnectWagon(w5);

        Console.WriteLine();
        train2.ConnectWagon(w7);
        train2.ConnectWagon(w8);
        train2.ConnectWagon(w9);
        train2.ConnectWagon(w10);
        train2.ConnectWagon(w11);
        train2.ConnectWagon(w11);

        Console.WriteLine();
        Console.WriteLine(train1.ToString());
        Console.WriteLine();
        Console.WriteLine(train2.ToString());
    }
}