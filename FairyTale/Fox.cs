using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    class Fox : Animal, IHungry
    {
        public string[] actingOfHut = { "растаяла", "взорвалась", "рассыпалась на кусочки", "развалилась",
            "расплавилась", "исчезла", "уплыла" };
        public Fox() : base("лисица", State.idle) { }

        public int satiety { get; set; }

        public override void GoAway()
        {
            Console.WriteLine("Как подскочит лисица да как побежит вон из зайкиной избушки, " +
                "а зайка и двери захлопнул за нею.");
        }

        public void Hungry()
        {
            Console.WriteLine("Я очень голодна! - сказала лисица.");
        }

        public new void Threaten()
        {
            Console.WriteLine("Ой, берегись: мой хвост что прут, — как дам, так и смерть тебе тут.");
        }
    }
}
