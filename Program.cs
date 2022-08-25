using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using Dungeons_Kingdom;
using CursorPosition;

namespace MainEngine
{
    static class TheEnd
    {
        public static void End()
        {
            ConsoleClear.Clear();

            Console.WriteLine("Ну что же, когда нибудь мы увидимся вновь =)");
            Console.WriteLine("До скорых встречь мой компаньон!");
            ConsoleClear.Clear();

            int x = 80;

            int y = 0;

            Thread.Sleep(1000);

            SetCursorPosition.CursorPosition(x, y);

            Console.Write("Над игрой работали: GinnSun");

            Thread.Sleep(444);

            y+= 2;

            SetCursorPosition.CursorPosition(x, y);

            Console.Write("Над сюжетом работал: GinnSun");

            Thread.Sleep(444);

            y += 2;

            SetCursorPosition.CursorPosition(x, y);

            Console.Write("Спасибо за то что поиграли в мою игру =)");

            Thread.Sleep(444);

            Thread.Sleep(1000);

            y += 2;

            SetCursorPosition.CursorPosition(x, y);

            Console.Write("THE END");
        }
    }

    

    class Progam
    {
        static void Main(string[] args) // от сбда происходит вообще запуск программы
        {
            Console.WriteLine("Откройте окно на полный экран и нажмите пробел чтобы начать игру =)");

            Console.ReadLine();

            ConsoleClear.Clear();


            BackGroundColor.SetBackGroundColor();

            Console.ReadLine();

            ConsoleClear.Clear();

            Introduction intro = new Introduction();
            intro.WelcomeAndStory();

            // проработать, то чтобы еще поиграть

            while (true)
            {
                if (Game.Ending == 2)
                {
                    Loading.PrintLoading();
                    Console.Write("Ох, как я вижу, вы получили не очень хорошую простую концовку, не так ли?");
                    Console.Write("Ну заставлять вас игра вновь не буду...");
                    Console.ReadLine();
                    Thread.Sleep(700);
                    Console.Write("Хотите ли сыграть еще раз?");
                    Console.WriteLine("1. Да | 2. Нет");
                    string userChoice = Console.ReadLine();
                    if (userChoice == "1")
                    {
                        ForeGroundColor.SetColorForHit();
                        Console.WriteLine("ХА ХА ХА");
                        Console.WriteLine("НУ ЧТО ЖЕ ПРОДОЛЖИМ!!!");
                        ForeGroundColor.SetColorBase();
                        Game userNewGame = new Game();
                        
                        userNewGame.ResultateLogics();

                    }
                    else
                    {
                        TheEnd.End();
                    }
                }
                else if (Game.Ending == 1)
                {
                    Loading.PrintLoading();
                    Console.Write("Я погляжу вы получили плохую сюжетную концовку...");
                    Console.ReadLine();
                    Console.Write("Ну заставлять вас игра вновь не буду...");
                    Console.ReadLine();
                    Console.Write("Ну что же было приятно смотреть за вашей игрой =)");
                    Console.ReadLine();
                    Console.Write("Спасибо за прохождение моей игры и удачи...");
                    Console.ReadLine();
                    Thread.Sleep(444);
                    TheEnd.End();
                }
                else if (Game.Ending == 3)
                {
                    Loading.PrintLoading();

                    Console.Write("Вы прошли игру так как я и хотел =)");
                    Console.ReadLine();
                    Console.Write("Молодец)");
                    Console.ReadLine();
                    Console.Write("Ну заставлять вас игра вновь не буду...");
                    Console.ReadLine();
                    Console.Write("Ну что же было приятно смотреть за вашей игрой =)");
                    Console.ReadLine();
                    Console.Write("Спасибо за прохождение моей игры и удачи...");
                    Console.ReadLine();

                    Thread.Sleep(444);
                    TheEnd.End();
                }
            }
        }
    }
}