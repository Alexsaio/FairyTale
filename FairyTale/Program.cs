using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    #region Enum definition 
    public enum Name
    {
        волк,
        медведь,
        петух,
        лисица,
        заяц
    }
    public enum State
    {
        idle,
        fright,
        daring
    }
    #endregion Enum defenition

    #region Program definition
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сказка Заюшкина избушка.\n\n");
            Hare hare = new Hare();
            Fox fox = new Fox();
            Random random = new Random();
            Console.WriteLine("Жили-были в лесу лисичка и зайка. Жили они неподалёку друг от друга. Пришла осень. " +
                "Холодно стало в лесу. Решили они избушки на зиму построить.");
            string hareMaterialHut = hare.materialOfHut[random.Next(0, hare.materialOfHut.Length)];
            string foxMaterialHut = fox.materialOfHut[random.Next(0, fox.materialOfHut.Length)];
            string foxActingOfHut = fox.actingOfHut[random.Next(0, fox.actingOfHut.Length)];
            Console.WriteLine($"Лисичка построила себе избушку из сыпучего {foxMaterialHut}, а зайчик — " +
                $"из сыпучего {hareMaterialHut}. Перезимовали они в новых избушках. Настала весна, пригрело солнце. " +
                $"Лисичкина избушка {foxActingOfHut}, а зайкина стоит, как стояла. Пришла лисица в зайкину избушку, " +
                $"выгнала зайку, а сама в его избушке осталась.");

            Console.WriteLine($"Пошёл зайка со своего двора, сел под берёзкою и плачет.");
            int animalNameWhichSpeakWithHare = random.Next(0, 2);
            int foxState = random.Next(0, 3);
            int i = 0;
            do
            {
                i++;
                switch (animalNameWhichSpeakWithHare)
                {
                    case 0:
                        Wolf wolf = new Wolf();
                        Console.WriteLine($"Идёт волк. Видит — зайка плачет.");
                        Console.WriteLine(wolf.AskHare() + wolf.name);
                        hare.TellHistory(foxMaterialHut, hareMaterialHut, foxActingOfHut);
                        wolf.Say();
                        Console.WriteLine("Пошли они. Пришли. Волк стал на пороге зайкиной избушки и кричит на лисичку:");
                        wolf.Threaten();
                        if(foxState != (int)State.daring)
                        {
                            Console.WriteLine("Не испугалась лисичка, отвечает волку:");
                            fox.Threaten();
                            wolf.state = State.fright;
                            Console.WriteLine("Испугался волк да наутёк. И зайку покинул. Сел опять зайка под берёзкой и горько плачет.");
                        }
                        else
                        {
                            fox.state = State.fright;
                            fox.GoAway();
                        }
                        break;
                    case 1:
                        Bear bear = new Bear();
                        Console.WriteLine("Идёт по лесу медведь. Видит — зайчик сидит под берёзкой и плачет.");
                        Console.WriteLine(bear.AskHare() + bear.name);
                        hare.TellHistory(foxMaterialHut, hareMaterialHut, foxActingOfHut);
                        bear.Say();
                        Console.WriteLine("Пошли они. Пришли. Медведь стал на пороге зайкиной избушки и кричит на лисичку:");
                        bear.Threaten();
                        if (foxState != (int)State.daring)
                        {
                            Console.WriteLine("Не испугалась лисичка, отвечает медведю:");
                            fox.Threaten();
                            bear.state = State.fright;
                            Console.WriteLine("Испугался медведь да наутёк и зайку одного покинул. Опять пошёл зайка со своего двора, сел под берёзкою и горько плачет.");
                        }
                        else
                        {
                            fox.state = State.fright;
                            fox.GoAway();
                        }
                        break;
                    case 2:
                        Cock cock = new Cock();
                        Console.WriteLine("Вдруг видит — идёт по лесу петух. Увидел зайчика, подошёл и спрашивает:");
                        Console.WriteLine(cock.AskHare() + cock.name);
                        hare.TellHistory(foxMaterialHut, hareMaterialHut, foxActingOfHut);
                        cock.Say();
                        Console.WriteLine("— Ой, петенька,— плачет зайка,— где тебе её выгнать?");
                        cock.Threaten();
                        if (foxState != (int)State.daring)
                        {
                            fox.Threaten();
                            cock.state = State.fright;
                            Console.WriteLine("Испугался петух да наутёк. И зайку покинул. Сел опять зайка под берёзкой и горько плачет.");
                        }
                        else
                        {
                            fox.state = State.fright;
                            fox.GoAway();
                        }
                        break;
                    default:
                        break;
                }
            } while (fox.state != State.fright && i>5);

            if (fox.state != State.fright)
                hare.GoAway();
            Console.WriteLine("Конец!");
            Console.ReadKey();
        }
    }
    #endregion

    #region Animal definition
    abstract class Animal
    {
        public string[] materialOfHut = { "снежка", "песка", "порошка", "угля", "керамзита", "бута", "чернозема" };
        public State state { get; set; }
        public Name name { get; set; }
        public Animal(Name name, State state)
        {
            this.name = name;
            this.state = state;
        }
        public string AskHare() 
        {
            return "— Чего ты, зайка, плачешь? — спрашивает ";
        }
        public abstract void Say();
        public abstract void GoAway();
        public abstract void Threaten();
    }
    #endregion

    #region Hare definition
    class Hare : Animal
    {
        public Hare() : base(Name.заяц, State.idle) { }

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

        public override void Say()
        {
            throw new NotImplementedException();
        }

        public override void Threaten()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Fox definition
    class Fox : Animal
    {
        public string[] actingOfHut = { "растаяла", "взорвалась", "рассыпалась на кусочки", "развалилась", 
            "расплавилась", "исчезла", "уплыла" };
        public Fox() : base(Name.лисица, State.idle) { }
        public override void Say()
        {
            throw new NotImplementedException();
        }

        public override void GoAway()
        {
            Console.WriteLine("Как подскочит лисица да как побежит вон из зайкиной избушки, " +
                "а зайка и двери захлопнул за нею.");
        }

        public override void Threaten()
        {
            Console.WriteLine("Ой, берегись: мой хвост что прут, — как дам, так и смерть тебе тут.");
        }
    }
    #endregion

    #region Wolf definition
    class Wolf : Animal
    {
        public Wolf() : base(Name.волк, State.idle) { }
        public override void Say()
        {
            Console.WriteLine("\n— Не плачь, зайка. Пойдём, я тебе помогу, выгоню лисичку из твоей избы.");
        }

        public override void Threaten()
        {
            Console.WriteLine("\n— Ты зачем залезла в чужую избу? Слезай, лиса, с печи, а то сброшу, побью тебе плечи.");
        }

        public override void GoAway()
        {
            Console.WriteLine("Испугался волк да наутёк. И зайку покинул. Сел опять зайка под берёзкой и горько плачет.");
        }
    }
    #endregion

    #region Bear definition
    class Bear : Animal
    {
        public Bear() : base(Name.медведь, State.idle) { }
        public override void GoAway()
        {
            Console.WriteLine("Испугался медведь да наутёк и зайку одного покинул. Опять пошёл зайка со своего двора," +
                " сел под берёзкою и горько плачет. ");
        }

        public override void Say()
        {
            Console.WriteLine("\n— Не плачь, зайка. Пойдём, я тебе помогу, выгоню лисичку из твоей избы.");
        }
        public override void Threaten()
        {
            Console.WriteLine("\n— Зачем отняла у зайки избу? Слезай, лиса, с печи, а то сброшу, побью тебе плечи.");
        }
    }
    #endregion

    #region Cock definition
    class Cock : Animal
    {
        public Cock() : base(Name.петух, State.idle) { }
        public override void GoAway()
        {
            Console.WriteLine("Испугался петушок да наутёк и зайку одного покинул. Опять пошёл зайка со своего двора, " +
                "сел под берёзкою и горько плачет. ");
        }

        public override void Say()
        {
            Console.WriteLine("\n— Не плачь, зайка, я выгоню лису из твоей избушки.");
        }
        public override void Threaten()
        {
            Console.WriteLine("— А вот я выгоню. Пойдём,— говорит петух. Пошли. Вошёл петух в избушку, стал на пороге," +
                " кукарекнул, а потом как закричит:— Я — петух-чебетух, Я — певун - лопотун, На коротких ногах, На высоких пятах." +
                "На плече косу несу, Лисе голову снесу.");
        }
    }
    #endregion
}
