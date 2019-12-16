using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    class StoryTeller
    {
        public void BeginStory(string hareMaterialHut, string foxMaterialHut, string foxActingOfHut)
        {
            Console.WriteLine("Сказка Заюшкина избушка.\n\n Жили-были в лесу лисичка и зайка. Жили они " +
                "неподалёку друг от друга. Пришла осень. Холодно стало в лесу. Решили они избушки на зиму построить.\n" +
                $"Лисичка построила себе избушку из сыпучего {foxMaterialHut}, а зайчик — " +
                $"из сыпучего {hareMaterialHut}. Перезимовали они в новых избушках. Настала весна, пригрело солнце. " +
                $"Лисичкина избушка {foxActingOfHut}, а зайкина стоит, как стояла. Пришла лисица в зайкину избушку, " +
                $"выгнала зайку, а сама в его избушке осталась.\n Пошёл зайка со своего двора, сел под берёзкою и плачет.");
        }

        public void FirstActionAnimal(int animalNameWhichSpeakWithHare)
        {
            if (animalNameWhichSpeakWithHare == 0)
                Console.WriteLine($"Идёт волк. Видит — зайка плачет.");
            else if (animalNameWhichSpeakWithHare == 1)
                Console.WriteLine("Идёт по лесу медведь. Видит — зайчик сидит под берёзкой и плачет.");
            else Console.WriteLine("Вдруг видит — идёт по лесу петух. Увидел зайчика, подошёл и спрашивает:");
        }

        public void SecondActionAnimal(int animalNameWhichSpeakWithHare)
        {
            if (animalNameWhichSpeakWithHare == 0)
                Console.WriteLine("Пошли они. Пришли. Волк стал на пороге зайкиной избушки и кричит на лисичку:");
            else if (animalNameWhichSpeakWithHare == 1)
                Console.WriteLine("Пошли они. Пришли. Медведь стал на пороге зайкиной избушки и кричит на лисичку:");
        }

        public void DontAfraidAnimal(int animalNameWhichSpeakWithHare)
        {
            if (animalNameWhichSpeakWithHare == 0)
                Console.WriteLine("Не испугалась лисичка, отвечает волку:");
            else if (animalNameWhichSpeakWithHare == 1)
                Console.WriteLine("Не испугалась лисичка, отвечает медведю:");
        }

        public void AfraidAnimal(int animalNameWhichSpeakWithHare)
        {
            if (animalNameWhichSpeakWithHare == 0)
                Console.WriteLine("Испугался волк да наутёк. И зайку покинул. Сел опять зайка под берёзкой и горько плачет.");
            else if (animalNameWhichSpeakWithHare == 1)
                Console.WriteLine("Испугался медведь да наутёк и зайку одного покинул. Опять пошёл зайка со своего двора, сел под берёзкою и горько плачет.");
            else Console.WriteLine("Испугался петух да наутёк. И зайку покинул. Сел опять зайка под берёзкой и горько плачет.");
        }

        public void TheEndStory()
        {
            Console.WriteLine("Конец!");
        }

        public void Random(int maxValue, out int rand)
        {
            Random random = new Random();
            rand = random.Next(0, maxValue);
        }
    }
}
