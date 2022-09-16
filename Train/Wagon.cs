using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    public abstract class Wagon {
        protected bool free = true;
        public void ConnectWagon(Train train) {
            if (free) {
                if (train.Locomotive.Engine.EngineType == engineType.steam) {
                    if (train.Wagons.Count == 5) {
                        Console.WriteLine($"It's not possible to join another wagon to train number {train.TrainNumber} with the \"{train.Locomotive.Engine}\" locomotive.");
                    } else {
                        train.Wagons.Add(this);
                        this.free = false;
                        Console.WriteLine($"{GetType().Name} was successfully joined to the train number {train.TrainNumber}.");
                    }
                } else {
                    train.Wagons.Add(this);
                    this.free = false;
                    Console.WriteLine($"{GetType().Name} was successfully joined to the train number {train.TrainNumber}.");
                }
            } else {
                Console.WriteLine($"This wagon is already in use. You have to disconnect it at first.");
            }
        }
        public void DisconnectWagon(Train train) {
            if (train.Wagons.Contains(this)) {
                train.Wagons.Remove(this);
                this.free = true;
                Console.WriteLine($"{GetType().Name} was successfully disconnected from the train number {train.TrainNumber}.");
            } else
                Console.WriteLine("This wagon is not a part of the train so it cannot be disconnected.");
        }
    }
}
