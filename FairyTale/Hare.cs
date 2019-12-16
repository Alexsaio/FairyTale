using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    class Hare : Animal, ITalk
    {
        public Hare() : base("заяц", State.idle) { }

        public void TellHistory(string foxMaterialHut, string hareMaterialHut, string foxActingOfHut)
        {
            Console.Write($"— Как же мне, зайке, не плакать? Жили мы с лисичкой близко друг возле друга. " +
                $"Построили мы себе избы: я — из сыпучего {hareMaterialHut}, а она — из сыпучего {foxMaterialHut}. " +
                $"Настала весна. Её избушка {foxActingOfHut}, а моя стоит, как стояла. Пришла лисичка, выгнала меня из моей избушки" +
                $" и сама в ней жить осталась. Вот я и сижу да плачу.");
        }

        public override void GoAway() 
        {
            Console.WriteLine("И решил зайчик пойти и построить себе новую избушку, лучше прежней и подальше от лисицы.");
        }

        public void Say()
        {
            Console.WriteLine("— Ой, петенька,— плачет зайка,— где тебе её выгнать?");
        }
    }
}
