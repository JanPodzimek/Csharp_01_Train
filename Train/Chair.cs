using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    public class Chair {
        private bool nearWindow;
        private int number;
        private bool reserved;
        public bool NearWindow { get => nearWindow; set => nearWindow = value; }
        public int Number { get => number; set => number = value; }
        public bool Reserved { get => reserved; set => reserved = value; }
        public Chair(int number) {
            this.number = number;
            reserved = false;
        }
        public override string ToString() {
            return $"seat number: {number}, booked: {reserved}";
        }
    }
}
