using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    class Bear : Animal, ITalk
    {
        public Bear() : base("медведь", State.idle) { }
        public override void GoAway()
        {
            Console.WriteLine("Испугался медведь да наутёк и зайку одного покинул. Опять пошёл зайка со своего двора," +
                " сел под берёзкою и горько плачет. ");
        }

        public void Say()
        {
            Console.WriteLine("\n— Не плачь, зайка. Пойдём, я тебе помогу, выгоню лисичку из твоей избы.");
        }
        public new void Threaten()
        {
            Console.WriteLine("\n— Зачем отняла у зайки избу? Слезай, лиса, с печи, а то сброшу, побью тебе плечи.");
        }
    }
}
