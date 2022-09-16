using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    public abstract class PersonalWagon : Wagon {
        private List<Door> doors;
        private List<Chair> sits;
        protected int numberOfChairs;
        public int NumberOfChairs { get => numberOfChairs; set => numberOfChairs = value; }
        public List<Chair> Sits { get => sits; set => sits = value; }
        public List<Door> Doors { get => doors; set => doors = value; }

        public PersonalWagon(int numberOfChairs) {
            this.numberOfChairs = numberOfChairs;
            this.sits = new List<Chair>(numberOfChairs);
            for (int i = 0; i < numberOfChairs; i++) {
                Sits.Add(new Chair(i));
            }
            this.doors = new List<Door>();
        }
        public override string ToString() {
            return $"{GetType().Name}: number of seats: {NumberOfChairs}";
        }
    }
}
