using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursorPosition;


namespace Dungeons_Kingdom
{
    class GoInTheDungeons // класс в котором будет описанна логика если пользователь соберет отрад для похода в подземелья, здесь будет описана полная логика пождземелья
    {
        

        public static int NumberOfSuccessfulTrips = 0;

        public int FailedTrips = 0;

        private readonly Random rand = new Random();

        private int NumberOfHpMobs { get; set; }
        private int NumberOfHpBoss { get; set; }

        private int MobsDamage { get; set; }
        private int BossDamage { get; set; }

        private int UserSoldiersDamage { get; set; }
        private int UserSoldiersHp { get; set; }

        public GoInTheDungeons(int UserSoldiers)
        {
            UserSoldiersHp = UserSoldiers;

            UserSoldiersDamage = (int)(UserSoldiers * 1.5);
        }

        private readonly string[] PhraseMobs = {
            "Сейчас мы порвем твои войска!!!", "Ого, а кто тут пришел? Хотите чтобы вас убили?)", "Мы тут короли этой земли!",
            "Не понял, ты мне это сказал, в атаку!!", "Тут моя родня, а это я, а вам *****", "Ну чтоде поиграем детишки?)",
            "Эх опять они, ну чтоже придется вас вновь убить)", "Вы нам не ровня!", "Оба новая броня подъехала!",
        };

        private readonly string[] PhraseBoss = {
            "Вы сами решили свою судьбу...", "Вам не долго осталось, так хоть помолитес перед смертью...", "Let's dance?",
            "I GOT IT", "I'm Dungeon Master, give me 300 $ bucks", "Зря...",
            "И это всех кого ты привел на этот раз?", "Хахахахаха", "Хочу поесть вами)",
        };

        private readonly string[] NameBoss = {"=/*-+-={}][]-=)", "Кто я?", "Зря...", "Цуцун-даке", "Sam", "Dungeon Master"};

        private void WriteField(int x = 0, int y = 0, string symbol = "█") // метод который делает поля данжа
        {
            
            ForeGroundColor.SetColorForDungeon();
            int MaxValueForX = 210;
            int MaxValueForY = 49;
            while (x < MaxValueForX)
            {
                SetCursorPosition.CursorPosition(x,y);
                Console.Write(symbol);
                x++;
            }

            x = 0;

            while (y < MaxValueForY)
            {
                SetCursorPosition.CursorPosition(x, y);
                Console.Write(symbol);
                y++;
            }

            while (x < MaxValueForX)
            {
                SetCursorPosition.CursorPosition(x,y);
                Console.Write(symbol);
                x++;
            }

            while (y >= 0)
            {
                SetCursorPosition.CursorPosition(x, y);
                Console.Write(symbol);
                y--;
            }

            ForeGroundColor.SetColorBase();
        }

        private void LogicsWalkUserOnDungeon(int x = 0, int y = 0) // рассказываем пользователю про суть данжа и как в него играть
        {
            x = 5;
            y = 3;
            SetCursorPosition.CursorPosition(x, y);
            Console.Write("Привет король!");
            Console.ReadLine();
            y++;

            SetCursorPosition.CursorPosition(x,y);
            Console.Write("Сейчас я тебе расскажу, как играть и возможно пройти данж!");
            Console.ReadLine();
            y++;

            SetCursorPosition.CursorPosition(x,y);
            Console.Write("После моего рассказа появится выбор, куда ты хочешь пойти, в каждом данже будет, всего 7 комнат");
            Console.ReadLine();
            y++;

            SetCursorPosition.CursorPosition(x,y);
            Console.Write("В какой-то из комнат будет торговец, у которого ты сможешь купить, либо улучшение на здоровье твоих солдат, либо же улучшения на их урон, тебе выбирать самому =)");
            Console.ReadLine();
            y++;

            SetCursorPosition.CursorPosition(x,y);
            Console.Write("Также у него может быть секрет, если тебе повезет =)");
            Console.ReadLine();
            y++;

            SetCursorPosition.CursorPosition(x,y);
            Console.Write("Также в какой-то из комнат будет босс, тебе его надо одолеть, чтобы выйти из данжа!");
            Console.ReadLine();
            y++;

            SetCursorPosition.CursorPosition(x,y);
            Console.Write("Скоро все начнется!");
            Console.ReadLine();

            Thread.Sleep(1200);

            ConsoleClear.Clear();

            UserChoiceAndHisWalk();
        }

        private void UserChoiceAndHisWalk(int x = 0, int y = 0, int random = 0) // логика данжа
        {
            WriteField();

            int SuccessfulRomm = 0;

            int count = 0;

            x = 5;
            y = 5;

            SetCursorPosition.CursorPosition(x, y);
            Console.Write("Вы видите впереди дверь хотите ли в нее войти?");
            Console.ReadLine();
            y++;

            SetCursorPosition.CursorPosition(x, y); // в превый раз у польователя не будет выбора куда идти, а только в перед
            Console.Write("1. Да | 2. Да");
            Console.ReadLine();
            y++;

            SetCursorPosition.CursorPosition(x, y);
            Console.Write("");
            Console.ReadLine();

            while (count < 7) // семь комнат, по этому цикл до семи
            {
                x = 5;

                y = 5;

                if (count != 0) // если это не первая комната, тут уже разветвление по комнатам
                {
                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("В переди вы видите две комнаты, в какую хотите зайти?");
                    Console.ReadLine();
                    y++;

                    Console.Write("1. Левая | 2. Правая");
                    Console.ReadLine();
                    y++;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("");
                    Console.ReadLine();
                }

                if (count == 6) // Boss
                {
                    ConsoleClear.Clear();
                    WriteField();

                    x = 5;
                    y = 5;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("Вы защли в комнату и услышали какой-то голос: " + PhraseBoss[rand.Next(0, PhraseBoss.Length - 1)]);
                    Console.ReadLine();
                    y++;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("О нет! Это Босс данжа!");
                    Console.ReadLine();
                    y++;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("Бос увидел вас и с улыбкой на лице побежал к вам...");
                    Console.ReadLine();
                    y++;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("ГОТОВТЕСЬ, ТАК КАК ОН СЛИШКОМ СИЛЕН!!!");
                    Console.ReadLine();

                    ConsoleClear.Clear();

                    WriteField();

                    SuccessfulRomm = FightWithBoss();

                    if (SuccessfulRomm == 1)
                    {
                        NumberOfSuccessfulTrips++;
                        break;
                    }
                    else
                    {
                        FailedTrips = 1;
                        break;
                    }
                }


                random = rand.Next(0, 1);

                if (random == 0) // мобы
                {
                    ConsoleClear.Clear();
                    WriteField();

                    x = 5;
                    y = 5;
                    SetCursorPosition.CursorPosition(x, y);
                    Console.Write("Вы зашли в дверь и услышали какие-то голоса: " + PhraseMobs[rand.Next(0, PhraseMobs.Length - 1)]);
                    Console.ReadLine();
                    y++;

                    SetCursorPosition.CursorPosition(x, y);
                    Console.Write("О нет! Это обычные мобы!");
                    Console.ReadLine();
                    y++;

                    SetCursorPosition.CursorPosition(x, y);
                    Console.Write("Мобы тоже вас увидели, и побежали к вам. Сейчас будет бой!");
                    Console.ReadLine();

                    ConsoleClear.Clear();
                    WriteField();

                    SuccessfulRomm = FightWithMobs();

                    if (SuccessfulRomm == 1) // если комната была успешной
                    {
                        count++;
                    }
                    else if (SuccessfulRomm == 2)
                    {
                        FailedTrips = 1;
                        break;
                    }

                }
                else if (random == 1 || count == rand.Next(2,3)) // Торговец
                {
                    ConsoleClear.Clear();

                    WriteField();

                    x = 5;
                    y = 5;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("Вы зашли в комнату и увидели человека...");
                    Console.ReadLine();
                    y++;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("Он сидел за столом, и у него что-то лежало на столе...");
                    Console.ReadLine();
                    y++;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("Вы поняли что это торговец, и подошли к нему...");
                    Console.ReadLine();
                    y++;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("Вы видите предметы которые он предлогает и их всего лишь два...");
                    Console.ReadLine();
                    SuccessfulRomm = MerchantsRoom();

                    if (SuccessfulRomm == 1)
                    {
                        count++;
                    }
                    else if (SuccessfulRomm == 2)
                    {
                        FailedTrips = 1;
                        break;
                    }
                }

                Thread.Sleep(400);

                ConsoleClear.Clear();

            }

            if (NumberOfSuccessfulTrips == 0 && FailedTrips == 0)
                NumberOfSuccessfulTrips++;

        }

        private int FightWithBoss(int x = 0, int y = 0) // метод босс файта
        {

            BossDamage = rand.Next(10, 50);
            NumberOfHpBoss = rand.Next(50, 200);

            for (int i = 1; NumberOfHpBoss > 0 && UserSoldiersHp > 0; i++)
            {
                x = 90;
                y = 2;
                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Раунд: " + i);

                x = 5;
                y = 5;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Имя босса: " + NameBoss[rand.Next(0, NameBoss.Length - 1)]);

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Здоровье босса: " + NumberOfHpBoss);
                y += 2;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Здоровье ваших солдат: " + UserSoldiersHp);
                y++;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Босс нападает!!!");
                Console.ReadLine();
                y++;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Удар!!");
                Console.ReadLine();
                y++;

                ForeGroundColor.SetColorForDungeonHit();
                SetCursorPosition.CursorPosition(x,y);
                Console.Write("-_/-+[]");
                Console.ReadLine();
                y += 2;

                ForeGroundColor.SetColorBase();

                UserSoldiersHp -= BossDamage;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Ваши солдаты идут в атаку на босса!");
                Console.ReadLine();
                y++;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Удар!!");
                Console.ReadLine();
                y++;

                ForeGroundColor.SetColorForDungeonHit();
                SetCursorPosition.CursorPosition(x, y);
                Console.Write("-_/-+[]");
                Console.ReadLine();
                y++;

                ForeGroundColor.SetColorBase();

                NumberOfHpBoss -= UserSoldiersDamage;

                ConsoleClear.Clear();

                WriteField();
            }

            if (UserSoldiersHp > 0 && NumberOfHpBoss <= 0)
            {
                Thread.Sleep(400);
                ConsoleClear.Clear();

                Console.Write("Вы сумели победить босса...");
                Console.ReadLine();

                Console.Write("Не ожидал от вас такого, вы молодец...");
                Console.ReadLine();

                Console.Write("Все ваши солдаты тоже рады победе!");
                Console.ReadLine();

                Console.Write("Что же поздравляю вас с успешным прохождением данжа!");
                Console.ReadLine();

                Console.Write("Но не раслабляйтесь! В этой игре может случится все, что угодно... =)");
                Console.ReadLine();

                Console.Write("Скоро вы вернетесь к себе в государство так, что можете пока, что отдохнуть...");
                Console.ReadLine();
                Thread.Sleep(1000);
                ConsoleClear.Clear();

                return 1;
            }
            else
            {
                Thread.Sleep(400);
                ConsoleClear.Clear();

                Console.Write("Вы проиграли...");
                Console.ReadLine();

                Console.Write("Ваших солдат убил босс, и вас тоже...");
                Console.ReadLine();

                Console.Write("Но по-моему и мнению босса, вы и ваши солдаты умерли и сражались достойно!");
                Console.ReadLine();

                Console.Write("Вы не жалеете такой смерти...");
                Console.ReadLine();

                Console.Write("Вы умерли как настоящий рыцарь...");
                Console.ReadLine();


                return 2;
            }
        }


        private int FightWithMobs(int x = 0, int y = 0) // метод моб файта
        {

            MobsDamage = rand.Next(0,30);
            NumberOfHpMobs = rand.Next(1,100);

            for (int i = 1 ;NumberOfHpMobs > 0 && UserSoldiersHp > 0; i++)
            {
                x = 90;
                y = 3;
                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Раунд: " + i);
                x = 5;
                y = 5;
                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Здоровье мобов: " + NumberOfHpMobs);
                Console.ReadLine();
                y+= 2;

                SetCursorPosition.CursorPosition(x, y);
                Console.Write("Здоровье ваших солдат: " + UserSoldiersHp);
                Console.ReadLine();
                y++;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Мобы нападают на ваших солдат!");
                Console.ReadLine();
                y++;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Удар!");
                Console.ReadLine();
                y++;

                ForeGroundColor.SetColorForDungeonHit();
                SetCursorPosition.CursorPosition(x,y);
                Console.Write("-_/-+[]");
                Console.ReadLine();
                y += 2;

                ForeGroundColor.SetColorBase();
                UserSoldiersDamage -= MobsDamage;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Ваши солдаты идут в бой!");
                Console.ReadLine();
                y++;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Удар!");
                Console.ReadLine();
                y++;

                ForeGroundColor.SetColorForDungeonHit();
                SetCursorPosition.CursorPosition(x,y);
                Console.Write("-_/-+[]");
                Console.ReadLine();
                y++;

                ForeGroundColor.SetColorBase();
                NumberOfHpMobs -= UserSoldiersDamage;

                ConsoleClear.Clear();

                WriteField();
            }

            if (UserSoldiersHp > 0 && NumberOfHpMobs <= 0)
            {
                Thread.Sleep(400);
                ConsoleClear.Clear();
                WriteField();

                x = 5;
                y = 5;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Тебе удалось победить мобов!");
                Console.ReadLine();
                y++;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Скоро перед тобой вновь станет выбор куда идти");
                Console.ReadLine();
                y++;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Удачи в следующих комнатах!");
                Console.ReadLine();

                return 1;
            }
            else
            {
                Thread.Sleep(400);
                ConsoleClear.Clear();
                WriteField();

                x = 5;
                y = 5;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Всех твоих солдат убили...");
                Console.ReadLine();
                y++;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Как ты мог так с ними поступить?!");
                Console.ReadLine();

                return 2;
            }
        }


        private int MerchantsRoom(int x = 0, int y = 0, int randomForUserChoice = 0) // метод торговца
        {
            int userChoice = 0;

            ConsoleClear.Clear();

            WriteField();

            x = 5;
            y = 5;

            SetCursorPosition.CursorPosition(x,y);
            Console.Write("У торговца лежат два зелья...");
            Console.ReadLine();
            y++;

            SetCursorPosition.CursorPosition(x,y);
            Console.Write("Торговец вам сказал, что левое зелье поднимет ваше здоровье до небес, а правое урон");
            Console.ReadLine();
            y++;

            SetCursorPosition.CursorPosition(x,y);
            Console.Write("Что же выберите вы?");
            Console.ReadLine();
            y++;

            SetCursorPosition.CursorPosition(x,y);
            Console.Write("1. Левое зелье стоит: 10 | 2. Правое зелье стоит: 5");
            Console.ReadLine();
            y++;

            SetCursorPosition.CursorPosition(x,y);
            Console.Write("");
            int.TryParse(Console.ReadLine(), out userChoice);

            if (userChoice == 1)
            {
                Thread.Sleep(400);
                ConsoleClear.Clear();
                WriteField();

                x = 5;
                y = 5;

                randomForUserChoice = rand.Next(0,1);
                if (randomForUserChoice == 1)
                {
                    x = 5;
                    y = 5;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("Вы и ваши солдаты выпили зелье, и почуствовали какое-то не годование...");
                    Console.ReadLine();
                    y++;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("Все вокруг начали блевать кровью, вы поняли, что вас торговец обманул и подсунул смертельное зелье!");
                    Console.ReadLine();
                    y++;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("Вы умерли, не пройдя данж, такой нелепой смертью...");
                    Console.ReadLine();
                    return 2;
                }
                else
                {
                    x = 5;
                    y = 5;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("Вы приняли зелье и почутсвовали некую бодрость!");
                    Console.ReadLine();
                    y++;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("Вам и вашим солдатам стало гараздо лучше!");
                    Console.ReadLine();
                    y++;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("Вы только хотели поблагодарить торгоыца, но его уже не было...");
                    Console.ReadLine();
                    y++;

                    SetCursorPosition.CursorPosition(x,y);
                    Console.Write("Скоро вы продолжите путь так, что приготовтесь!");
                    Console.ReadLine();

                    UserSoldiersHp += rand.Next(10,50);

                    Game.coffers -= 10;

                    return 1;

                }
            }
            else
            {
                Thread.Sleep(600);
                ConsoleClear.Clear();
                WriteField();

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Купили и приняли зелье");
                Console.ReadLine();
                y++;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Вам и вашим солдатом стало лучше чем было!");
                Console.ReadLine();
                y++;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Удары ваших солдат стали сильнее!");
                Console.ReadLine();
                y++;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Вы только хотели отблагодарить торгоца, но его уже не было, он как будто испарился...");
                Console.ReadLine();
                y++;

                SetCursorPosition.CursorPosition(x,y);
                Console.Write("Скоро вы продолжите путь так, что приготовтесь!");
                Console.ReadLine();

                UserSoldiersDamage += rand.Next(5,50);

                Game.coffers -= 5;

                return 1;
            }

        }

        public void ResultOfTheDungeon() 
        {
            WriteField();
            LogicsWalkUserOnDungeon();
        }


    }
}
