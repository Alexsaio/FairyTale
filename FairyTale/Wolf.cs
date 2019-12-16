using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    class Wolf : Animal, ITalk
    {
        public Wolf() : base("волк", State.idle) { }
        public void Say()
        {
            Console.WriteLine("\n— Не плачь, зайка. Пойдём, я тебе помогу, выгоню лисичку из твоей избы.");
        }

        public new void Threaten()
        {
            Console.WriteLine("\n— Ты зачем залезла в чужую избу? Слезай, лиса, с печи, а то сброшу, побью тебе плечи.");
        }

        public override void GoAway()
        {
            Console.WriteLine("Испугался волк да наутёк. И зайку покинул. Сел опять зайка под берёзкой и горько плачет.");
        }
    }
}
