using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    abstract class Animal
    {
        public Name name { get; set; }

        public Animal(Name name) { }

        public string AskHare()
        {
            return "— Чего ты, зайка, плачешь? — спрашивает ";
        }

        public virtual void GoAway() { }

        public void Threaten() { }

        public void SpeakWithHare() { }
    }
}
