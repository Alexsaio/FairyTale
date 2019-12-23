using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FairyTale.StoryTeller;

namespace FairyTale
{
    class Hare : Animal, ITalk
    {
        public Hare() : base(Name.hare) { }

        public void TellHistory(string foxActingOfHut)
        {
            Console.Write($"— Как же мне, зайке, не плакать? Жили мы с лисичкой близко друг возле друга. " +
                $"Построили мы себе избы: я — лубяную, а она — ледяную. " +
                $"Настала весна. Её избушка {foxActingOfHut}, а моя стоит, как стояла. Пришла лисичка, выгнала меня из моей избушки" +
                $" и сама в ней жить осталась. Вот я и сижу да плачу.");
        }

        public void Say()
        {
            Console.WriteLine("— Ой, петенька,— плачет зайка,— где тебе её выгнать?");
        }
    }
}
