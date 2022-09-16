using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    public class NightWagon : PersonalWagon {
        private List<Bed> beds;
        private int numberOfBeds;
        public List<Bed> Beds { get => beds; set => beds = value; }
        public int NumberOfBeds { get => numberOfBeds; set => numberOfBeds = value; }

        public NightWagon(int numberOfChairs, int numberOfBeds) : base(numberOfChairs) {
            this.numberOfBeds = numberOfBeds;
            this.beds = new List<Bed>(NumberOfBeds);
            for (int i = 0; i < numberOfBeds; i++) {
                beds.Add(new Bed(i));
            }
        }
        public override string ToString() {
            return base.ToString() + $", number of beds: {NumberOfBeds}";
        }
    }
}
