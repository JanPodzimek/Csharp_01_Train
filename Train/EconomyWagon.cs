using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    public class EconomyWagon : PersonalWagon {
        public EconomyWagon(int numberOfChairs) : base(numberOfChairs) { }
        public override string ToString() {
            return base.ToString();
        }
    }
}
