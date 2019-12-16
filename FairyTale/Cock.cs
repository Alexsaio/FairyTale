using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    class Cock : Animal, ITalk
    {
        public Cock() : base("петух", State.idle) { }
        public override void GoAway()
        {
            Console.WriteLine("Испугался петушок да наутёк и зайку одного покинул. Опять пошёл зайка со своего двора, " +
                "сел под берёзкою и горько плачет. ");
        }

        public void Say()
        {
            Console.WriteLine("\n— Не плачь, зайка, я выгоню лису из твоей избушки.");
        }
        public new void Threaten()
        {
            Console.WriteLine("— А вот я выгоню. Пойдём,— говорит петух. Пошли. Вошёл петух в избушку, стал на пороге," +
                " кукарекнул, а потом как закричит:— Я — петух-чебетух, Я — певун - лопотун, На коротких ногах, На высоких пятах." +
                "На плече косу несу, Лисе голову снесу.");
        }
    }
}
