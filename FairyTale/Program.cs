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
        daring,
        bored
    }
    public enum Name
    {
        wolf,
        bear,
        cock,
        hare,
        fox
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StoryTeller storyTeller = new StoryTeller();
                storyTeller.Say();
            }
            catch
            {
                Console.WriteLine("\n\nУпс! Лиса была очень голодна и съела продолжение сказки. Возможно в следующий раз тебе повезет:)");
            }
            Console.ReadKey();
        }
    }
}
