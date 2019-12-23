using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    class Fox : Animal, IHungry<int>
    {

        public List<string> actingOfHut = new List<string> { "растаяла", "взорвалась", "рассыпалась на кусочки",
            "развалилась", "расплавилась", "исчезла", "уплыла"};

        public int satiety { get; set; }

        public State state{ get; set; }

        public Fox() : base(Name.fox) { state = State.idle; }

        public override void GoAway()
        {
            state = State.fright;
            Console.WriteLine("Как подскочит лисица да как побежит вон из зайкиной избушки, " +
                "а зайка и двери захлопнул за нею.");
        }

        public void Hungry()
        {
            Console.WriteLine("Я очень голодна! - сказала лисица.");
        }

        public void GetSatietyOfFox()
        {
            if (satiety <= 40)
            {
                Hungry();
                throw new Exception("Лиса жутко голодна!");
            }
        }

        public new void Threaten()
        {
            Console.WriteLine("- Ой, берегись: мой хвост что прут, — как дам, так и смерть тебе тут.");
        }
    }
}
