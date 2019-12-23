using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    class Wolf : Animal, ITalk
    {
        public Wolf() : base(Name.wolf) { }

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

        public void SpeakWithHare(Hare hare, string foxActingOfHut, Fox fox)
        {
            Console.WriteLine($"Идёт волк. Видит — зайка плачет.");
            Console.WriteLine(AskHare() + "волк.");
            hare.TellHistory(foxActingOfHut);
            Say();
            Console.WriteLine("Пошли они. Пришли. Волк стал на пороге зайкиной избушки и кричит на лисичку:");
            Threaten();
            if (fox.state == State.fright)
            {
                fox.GoAway();
            }
            else
            {
                Console.WriteLine("Не испугалась лисичка, отвечает волку:");
                fox.Threaten();
                Console.WriteLine("Испугался волк да наутёк. И зайку покинул. Сел опять зайка под берёзкой и горько плачет.");
            }
        }
    }
}
