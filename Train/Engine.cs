using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    public enum engineType { unknow, diesel, electric, steam };
    public class Engine {
        private engineType engineType;
        public engineType EngineType { get => engineType; set => engineType = value; }
        public Engine(engineType engineType) {
            this.engineType = engineType;
        }
        public override string ToString() {
            return $"{engineType}";
        }
    }
}
