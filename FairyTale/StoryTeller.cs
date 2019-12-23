using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    class StoryTeller : ITalk
    {
        public delegate void Story(Hare hare, string foxActingOfHut, Fox fox);

        RandomValue random = new RandomValue();

        public void BeginStory(string foxActingOfHut)
        {
            Console.WriteLine("Сказка Заюшкина избушка.\n\n Жили-были в лесу лисичка и зайка. Жили они " +
                "неподалёку друг от друга. Пришла осень. Холодно стало в лесу. Решили они избушки на зиму построить.\n" +
                $"Лиса построила себе ледяную избушку, а заяц - лубяную. Перезимовали они в новых избушках. " +
                $"Настала весна, пригрело солнце. Лисичкина избушка {foxActingOfHut}, а зайкина стоит, как стояла. " +
                $"Пришла лисица в зайкину избушку, выгнала зайку, а сама в его избушке осталась." +
                $"\n Пошёл зайка со своего двора, сел под берёзкою и плачет.");
        }
        public void TheEndStory()
        {
            Console.WriteLine("Конец!");
        }

        public void Say()
        {
            Fox fox = new Fox();
            Hare hare = new Hare();
            int i = 0;
            GetRandomValues(out string foxActingOfHut, fox);
            BeginStory(foxActingOfHut);
            fox.GetSatietyOfFox();

            do
            {
                int animalNameWhichSpeakWithHare = random.GenerateRandom(4);
                fox.state = (State)random.GenerateRandom(3);
                Story deleg;
                i++;
                if (animalNameWhichSpeakWithHare == (int)Name.wolf)
                {
                    Wolf wolf = new Wolf();
                    deleg = wolf.SpeakWithHare;
                }
                else if (animalNameWhichSpeakWithHare == (int)Name.bear)
                {
                    Bear bear = new Bear();
                    deleg = bear.SpeakWithHare;
                }
                else
                {
                    Cock cock = new Cock();
                    deleg = cock.SpeakWithHare;
                }
                deleg(hare, foxActingOfHut, fox);
            } while (fox.state != State.fright);

            TheEndStory();
        }

        public void GetRandomValues(out string foxActingOfHut, Fox fox)
        {
            foxActingOfHut = fox.actingOfHut[random.GenerateRandom(7)];
            fox.satiety = random.GenerateRandom(100);
        }
    }
}
