using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    public interface IConnectable {
        public virtual void ConnectWagon(Train train) { }
        public virtual void DisconnectWagon(Train train) { }
    }
}
