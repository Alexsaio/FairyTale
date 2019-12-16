using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    abstract class Animal
    {
        public string[] materialOfHut = { "снежка", "песка", "порошка", "угля", "керамзита", "бута", "чернозема" };
        public State state { get; set; }
        public string name { get; set; }
        public Animal(string name, State state)
        {
            this.name = name;
            this.state = state;
        }
        public string AskHare()
        {
            return "— Чего ты, зайка, плачешь? — спрашивает ";
        }
        public virtual void GoAway() { }
        public void Threaten() { }
    }
}
