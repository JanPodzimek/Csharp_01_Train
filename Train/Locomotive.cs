using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train {
    public class Locomotive {
        private Person person = new Person();
        private Engine engine = new Engine(engineType.unknow);
        public Person Person { get => person; set => person = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public Locomotive() {
            person.FirstName = "unknown";
            person.LastName = "unknown";
            Engine = engine;
        }
        public Locomotive(Person person, Engine engine) {
            this.person = person;
            this.engine = engine;
        }

        public override string ToString() {
            return $"{GetType().Name}: engine > {engine}, driver: {person.FirstName} {person.LastName}";
        }
    }
}
