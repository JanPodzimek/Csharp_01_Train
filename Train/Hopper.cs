using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    public class Hopper : Wagon {
        private const double LOADING_CAPACITY = 40;
        private double tonnage;
        public double LoadingCapacity { get => LOADING_CAPACITY; }
        public double Tonnage { get => tonnage; set => tonnage = value; }

        public Hopper(double tonnage) {
            if (tonnage > LOADING_CAPACITY || tonnage < 0)
                this.tonnage = 0;
            else
                this.tonnage = tonnage;
        }
        public override string ToString() {
            return $"{GetType().Name}";
        }
    }
}
