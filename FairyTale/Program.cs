using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FairyTale
{
    public enum State
    {
        idle,
        fright,
        daring
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StoryTeller storyTeller = new StoryTeller();
                Hare hare = new Hare();
                Fox fox = new Fox();

                storyTeller.Random(hare.materialOfHut.Length, out int randHare);
                storyTeller.Random(fox.materialOfHut.Length, out int randFox);
                storyTeller.Random(fox.actingOfHut.Length, out int randFoxAct);
                string hareMaterialHut = hare.materialOfHut[randHare];
                string foxMaterialHut = fox.materialOfHut[randFox];
                string foxActingOfHut = fox.actingOfHut[randFoxAct];
                storyTeller.BeginStory(hareMaterialHut, foxMaterialHut, foxActingOfHut);
                storyTeller.Random(2, out int rand);
                int animalNameWhichSpeakWithHare = rand;
                storyTeller.Random(3, out int randstate);
                int foxState = randstate;
                int i = 0;

                // ошибка в логике работы
                storyTeller.Random(70, out int satietyOfFox);
                if (satietyOfFox <= 45)
                {
                    fox.Hungry();
                    throw new Exception("Лиса жутко голодна!");
                }

                do
                {
                    i++;
                    switch (animalNameWhichSpeakWithHare)
                    {
                        case 0:
                            Wolf wolf = new Wolf();
                            storyTeller.FirstActionAnimal(animalNameWhichSpeakWithHare);
                            Console.WriteLine(wolf.AskHare() + wolf.name);
                            hare.TellHistory(foxMaterialHut, hareMaterialHut, foxActingOfHut);
                            wolf.Say();
                            storyTeller.SecondActionAnimal(animalNameWhichSpeakWithHare);
                            wolf.Threaten();
                            if (foxState != (int)State.daring)
                            {
                                storyTeller.DontAfraidAnimal(animalNameWhichSpeakWithHare);
                                fox.Threaten();
                                wolf.state = State.fright;
                                storyTeller.AfraidAnimal(animalNameWhichSpeakWithHare);
                            }
                            else
                            {
                                fox.state = State.fright;
                                fox.GoAway();
                            }
                            break;
                        case 1:
                            Bear bear = new Bear();
                            storyTeller.FirstActionAnimal(animalNameWhichSpeakWithHare);
                            Console.WriteLine(bear.AskHare() + bear.name);
                            hare.TellHistory(foxMaterialHut, hareMaterialHut, foxActingOfHut);
                            bear.Say();
                            storyTeller.SecondActionAnimal(animalNameWhichSpeakWithHare);
                            bear.Threaten();
                            if (foxState != (int)State.daring)
                            {
                                storyTeller.DontAfraidAnimal(animalNameWhichSpeakWithHare);
                                fox.Threaten();
                                bear.state = State.fright;
                                storyTeller.AfraidAnimal(animalNameWhichSpeakWithHare);
                            }
                            else
                            {
                                fox.state = State.fright;
                                fox.GoAway();
                            }
                            break;
                        case 2:
                            Cock cock = new Cock();
                            storyTeller.FirstActionAnimal(animalNameWhichSpeakWithHare);
                            Console.WriteLine(cock.AskHare() + cock.name);
                            hare.TellHistory(foxMaterialHut, hareMaterialHut, foxActingOfHut);
                            cock.Say();
                            hare.Say();
                            cock.Threaten();
                            if (foxState != (int)State.daring)
                            {
                                fox.Threaten();
                                cock.state = State.fright;
                                storyTeller.AfraidAnimal(animalNameWhichSpeakWithHare);
                            }
                            else
                            {
                                fox.state = State.fright;
                                fox.GoAway();
                            }
                            break;
                    }
                } while (fox.state != State.fright && i > 5);

                if (fox.state != State.fright)
                    hare.GoAway();
                storyTeller.TheEndStory();
            }
            catch
            {
                Console.WriteLine("\n\nУпс! Лиса была очень голодна и съела продолжение сказки. Возможно в следующий раз тебе повезет:)");
            }
            Console.ReadKey();
        }
    }
}
