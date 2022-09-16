using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    public class BusinessWagon : PersonalWagon {
        private Person steward = new Person();
        public Person Steward { get => steward; set => steward = value; }
        public BusinessWagon(Person steward, int numberOfChairs) : base(numberOfChairs) {
            this.steward = steward;
        }
        public override string ToString() {
            return base.ToString() + $", steward: {Steward}";
        }
    }
}
