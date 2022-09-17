using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    public class Train : IConnectable {
        private static int numberOfTrains = 0;
        private int trainNumber;
        private Locomotive locomotive;
        private List<Wagon> wagons;
        public Locomotive Locomotive { get => locomotive; set => locomotive = value; }
        public List<Wagon> Wagons { get => wagons; set => wagons = value; }
        public static int NumberOfTrains { get => numberOfTrains; set => numberOfTrains = value; }
        public int TrainNumber { get => trainNumber; set => trainNumber = value; }

        public Train() {
            numberOfTrains++;
            locomotive = new Locomotive();
            wagons = new List<Wagon>();
            trainNumber = numberOfTrains;
        }
        public Train(Locomotive locomotive) {
            numberOfTrains++;
            this.locomotive = locomotive;
            wagons = new List<Wagon>();
            trainNumber = numberOfTrains;
        }
        public Train(Locomotive locomotive, List<Wagon> wagons) {
            numberOfTrains++;
            this.locomotive = locomotive;
            this.wagons = wagons;
            trainNumber = numberOfTrains;
        }
        public void ConnectWagon(Wagon wagon) {
            wagon.ConnectWagon(this);
        }
        public void DisconnectWagon(Wagon wagon) {
            wagon.DisconnectWagon(this);
        }
        public string printWagons() {
            string x = "";
            for (int i = 0; i < wagons.Count; i++)
                x += $"-wagon number {i + 1} " + $"({wagons[i].ToString()})" + "\n";
            return x;
        }
        public void reserveSeat(int numberOfWagon, int numberOfSeat) {
            if (wagons.Count == 0) {
                Console.WriteLine("This train has no wagons, so no reservation is possible.");
            } else {
                if (wagons[numberOfWagon - 1] is PersonalWagon pers) {
                    if (numberOfSeat <= pers.NumberOfChairs) {
                        if (!pers.Sits[numberOfSeat - 1].Reserved) {
                            pers.Sits[numberOfSeat - 1].Reserved = true;
                            Console.WriteLine($"Seat number {numberOfSeat} in wagon {numberOfWagon} was successfully booked.");
                        } else {
                            Console.WriteLine($"Sorry, seat number {numberOfSeat} in wagon {numberOfWagon} is already booked.");
                        }
                    } else {
                        Console.WriteLine($"Wagon number {numberOfWagon} doesn't contain any seat with this number.");
                    }
                } else {
                    Console.WriteLine($"There are no seats in wagon {numberOfWagon}.");
                }
            }
        }
        public void reserveBed(int numberOfWagon, int numberOfBed) {
            if (wagons.Count == 0) {
                Console.WriteLine("This train has no wagons, so no reservation is possible.");
            } else {
                if (wagons[numberOfWagon - 1] is NightWagon night) {
                    if (numberOfBed <= night.NumberOfChairs) {
                        if (!night.Beds[numberOfBed - 1].Reserved) {
                            night.Beds[numberOfBed - 1].Reserved = true;
                            Console.WriteLine($"Bed number {numberOfBed} in wagon {numberOfWagon} was successfully booked.");
                        } else {
                            Console.WriteLine($"Sorry, bed number {numberOfBed} in wagon {numberOfWagon} is already booked.");
                        }
                    } else {
                        Console.WriteLine($"Wagon number {numberOfWagon} doesn't contain any bed with this number.");
                    }
                } else {
                    Console.WriteLine($"There are no beds in wagon number {numberOfWagon}.");
                }
            }
        }
        public void cancelSeatReservation(int numberOfWagon, int numberOfSeat) {
            if (numberOfWagon <= wagons.Count && numberOfWagon > 0) {
                if (this.Wagons[numberOfWagon - 1] is PersonalWagon pers) {
                    if (numberOfSeat <= pers.NumberOfChairs) {
                        if (pers.Sits[numberOfSeat - 1].Reserved) {
                            pers.Sits[numberOfSeat - 1].Reserved = false;
                            Console.WriteLine($"Reservation of seat number {numberOfSeat} in wagon number {numberOfWagon} was successfully cancelled.");
                        } else {
                            Console.WriteLine($"You cannot cancel seat reservation of free seat.");
                        }
                    } else {
                        Console.WriteLine($"There is no seat number {numberOfSeat} in wagon number {numberOfWagon}.");
                    }
                } else {
                    Console.WriteLine($"There are no seats in wagon number {numberOfWagon}.");
                }
            } else {
                Console.WriteLine($"Wagon number {numberOfWagon} does not exist in current context.");
            }
        }
        public void cancelBedReservation(int numberOfWagon, int numberOfBed) {
            if (numberOfWagon <= wagons.Count && numberOfWagon > 0) {
                if (this.Wagons[numberOfWagon - 1] is NightWagon night) {
                    if (numberOfBed <= night.NumberOfChairs) {
                        if (night.Beds[numberOfBed - 1].Reserved) {
                            night.Beds[numberOfBed - 1].Reserved = false;
                            Console.WriteLine($"Reservation of bed number {numberOfBed} in wagon number {numberOfWagon} was successfully cancelled.");
                        } else {
                            Console.WriteLine($"You cannot cancel seat reservation of free seat.");
                        }
                    } else {
                        Console.WriteLine($"There is no bed number {numberOfBed} in wagon number {numberOfWagon}.");
                    }
                } else {
                    Console.WriteLine($"There are no beds in wagon number {numberOfWagon}.");
                }
            } else {
                Console.WriteLine($"Wagon number {numberOfWagon} does not exist in current context.");
            }
        }
        public void listReservedSeats() {
            string x = "", bookedSeats = "";
            for (int i = 0; i < wagons.Count; i++) {
                if (wagons[i] is PersonalWagon pers) {
                    x += $"Wagon number {i + 1}, booked seats: ";
                    foreach (Chair ch in pers.Sits) {
                        if (ch.Reserved)
                            bookedSeats += $"{ch.Number + 1}, ";
                    }
                    if (bookedSeats.CompareTo("") == 0)
                        x += "No booked seats.";
                    Console.WriteLine(x + bookedSeats);
                }
                x = "";
                bookedSeats = "";
            }
        }
        public void listReservedBeds() {
            string x = "", bookedBeds = "";
            for (int i = 0; i < wagons.Count; i++) {
                if (wagons[i] is NightWagon night) {
                    x += $"Wagon number {i + 1}, booked seats: ";
                    foreach (Bed b in night.Beds) {
                        if (b.Reserved)
                            bookedBeds += $"{b.Number + 1}, ";
                    }
                    if (bookedBeds.CompareTo("") == 0)
                        x += "No booked beds.";
                    Console.WriteLine(x + bookedBeds);
                }
                x = "";
                bookedBeds = "";
            }
        }
        public override string ToString() {
            return $"{GetType().Name} number {trainNumber}\n{locomotive.ToString()}\nWagons:\n{printWagons()}";
        }
    }
}
