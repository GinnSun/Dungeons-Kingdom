using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_Kingdom
{
    class Introduction // Введение
    {
        private const string firstSymbol = "/";
        private const string secondSymbol = "|";
        private const string thirdSymbol = "\\";

        private const int countForFirstSymbol = 10;
        private const int countForSecondSymbol = 16;
        private const int countForThirdSymbol = 10;

        private static void SetForeGroundColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void WelcomeAndStoryAboutTheGame()
        {
            Intro();

            void Intro(int x = 0, int y = 0)
            {
                string firstSymbolForIntro = string.Concat(Enumerable.Repeat(firstSymbol, countForFirstSymbol));
                string secondSymbolForIntro = string.Concat(Enumerable.Repeat(secondSymbol, countForSecondSymbol));
                string thirdSymbolForIntro = string.Concat(Enumerable.Repeat(thirdSymbol, countForThirdSymbol));
                x = 90;
                y = 0;
                Console.SetCursorPosition(x, y);
                Console.Write(firstSymbolForIntro + secondSymbolForIntro + thirdSymbolForIntro);
                Sleep();
                Console.SetCursorPosition(x, y + 1);
                Console.Write(firstSymbolForIntro + "DUNGEONS KINGDOM" + thirdSymbolForIntro);
                Sleep();
                Console.SetCursorPosition(x, y + 2);
                Console.Write(firstSymbolForIntro + secondSymbolForIntro + thirdSymbolForIntro);
                Sleep();

                Insertion();
            }

            void DownSpace()
            {
                for (int i = 0; i < 10; i++)
                    Console.WriteLine();
            }

            void Insertion()
            {
                DownSpace();
                Console.Write("Привет будущий вождь!");
                PushEnter();
                Console.Write("Сейчас я тебе расскажу, что это за игра и как в нее играть!");
                PushEnter();
                Console.Write("Ты вождь или же король, как тебе удобнее, ты правишь своим маленьким только, что созданным государством!");
                PushEnter();
                Console.Write("У тебя нет подчиненных, чтобы делать какие-то поручения, но ты их можем найти и предложить жить и трудится во благо твоего государства!");
                PushEnter();
                Console.Write("Каждые 2 дня к тебе будет приходить один новый подчиненный, то есть твой будущий житель!");
                PushEnter();
                Console.Write("Как благородный король ты его в любом случае примешь!");
                PushEnter();
                Console.Write("Своих подчиненных (жителей) ты можем отправлять на вылозки в хозяйство или же в данжи (подземелья)");
                PushEnter();
                Console.Write("У твоих подчинненых будет имется общий голод, который будет падать, взависимости от того куда ты отправишь своего подчиненного или же подчиненных!");
                PushEnter();
                Console.Write("Отправив его в хозяйство он сможет найти себе пропитание и не умерет от голода, хехехех =)");
                PushEnter();
                Console.Write("Но в течение каждых 10 дней на тебя будут нападь разбойники так, что учти это!");
                PushEnter();
                Console.Write("если разбойники разграбят твое государство, то ты проиграл...");
                PushEnter();
                Console.Write("Ты можешь выставлять своих жителей как в защитe государства, но им придется платить монеты, за день они просят всего лишь 1 монету!");
                PushEnter();
                Console.Write("Ах да забыл сказать, каждый подчиненный в день платит тебе по одной монете за проживание!");
                PushEnter();
                Console.Write("Если ты захочешь отправить своих жителей в данж, то учти, что они там могут умереть и игра закончится, придется проходить заново!");
                PushEnter();
                Console.Write("Но если твои жители пройдут данж и вернутся, они станут рыцарями твоего города, и в честь этого жители рыцарям построят памятники и храмы");
                PushEnter();
                Console.Write("Чтобы пройти игру, надо чтобы твои жители стали рыцарями, а после сходить этими рыцарями в данж пять раз!");
                PushEnter();
                Console.Write("Если твои рыцари умрут в данже, то вера в них упадет и ваше государтсво ослабнет, что приведет к краху и вашему проигрышу!");
                PushEnter();
                Console.Write("Но если вы все таки сможете пройти рыцарями все 5 раз данж, то у вас будет выбор кого поставить на свой пост и кто в дальнейшем будет править государством!");
                PushEnter();
                Console.Write("От того кого вы выберите зависит концовка игры!");
                PushEnter();
                Console.Write("Ну так пожалуй начнем ИГРУ!");

                Loading.PrintLoading();

                Game firstUserGame = new Game();

                firstUserGame.ResultateLogics();
            }

            void PushEnter()
            {
                Console.ReadLine();
            }

        }

        private void Sleep()
        {
            Thread.Sleep(500);
        }

        public void WelcomeAndStory()
        {
            SetForeGroundColor();
            WelcomeAndStoryAboutTheGame();
        }


    }

    static class BackGroundColor
    {
        public static void SetBackGroundColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
    }
}
