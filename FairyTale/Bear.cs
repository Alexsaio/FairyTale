using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    class Bear : Animal, ITalk
    {
        public Bear() : base(Name.bear) { }

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

        public void SpeakWithHare(Hare hare, string foxActingOfHut, Fox fox)
        {
            Console.WriteLine("Идёт по лесу медведь. Видит — зайчик сидит под берёзкой и плачет.");
            Console.WriteLine(AskHare() + "медведь.");
            hare.TellHistory(foxActingOfHut);
            Say();
            Console.WriteLine("Пошли они. Пришли. Медведь стал на пороге зайкиной избушки и кричит на лисичку:");
            Threaten();
            if (fox.state == State.fright)
            {
                fox.GoAway();
            }
            else
            {
                Console.WriteLine("Не испугалась лисичка, отвечает медведю:");
                fox.Threaten();
                Console.WriteLine("Испугался медведь да наутёк и зайку одного покинул. Опять пошёл зайка со своего " +
                    "двора, сел под берёзкою и горько плачет.");
            }
        }
    }
}
