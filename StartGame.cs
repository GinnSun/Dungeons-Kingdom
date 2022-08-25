using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursorPosition;

namespace Dungeons_Kingdom
{
    class Game // класс в котором в принципе будет описанна, почти вся логика игры, кроме данжей, а так в принциеп будет описанна вся логика игры
    {
        private static readonly string[] PhraseOfNewResidents = {
            "Привет король этих земель, можно мне стать твоим поданным?!",
            "Хо-хо-хо я тут вижу новый король объявился, ну старый не долго протянул хехехе, так что возмешь меня?",
            "Я тут подумал я можно я стану гражданином твоего королевства?", "Боже правый нашел!\nМогу я вступить к тебе? Я опытный воин!",
            "Я тут жил когда-то давно, до твоего правления, но к сожелению царство то распалось, могу ли я вступить к тебе?", "Эх не это я искал, но и тут в принципе нормально...",
            "Я бог =)", "Я был могучим добытчиком еды, прошу прими меня!", "Я просто подвигами маюсь...", "Но это не Коноха?!", "Я блин облетел тысячи галактик! Чтобы в итоге присоеденится к тебе?!",
            "Я знаю пароль от вайфая прими пж =)", "Я просто похлопаю (звук хлопка в ладоши)", "Ты нарываешься?!", "Hello my friend. i from Pakistan =)", "I'm Billye Herington", "0101010111010101101110100", "/*-/-=+=/-*_-)())+}{]{||]?"
        };
        private static readonly string[] PhraseOfInhabitantsOfTheEconomy = {
            "Эх идти работать а я так хотел по спать...", "МНЕ ИДТИ РАБОТАТЬ????\nЛадно",
            "Я призван работать, да поможет мне бог с этим испытанием!", "Мне чем-то это напосинает один недавний культ... =/", "Я буду работать? Спасибо!",
            "Well okay, i go to job =(", "I'm Billye Herington", "=-[]-/*-+'/^%$@!){}[/*+]?", "Я Бог =)", "Вообще-то я тут король...", 
            "Не понял, КТО Я?", "ДИСПЕТЧЕР МЫ ПАДАЕМ, МЫ ПАДАЕМ!\nПонял вычеркиваю!", "Ну если того просит король, то я не могу не сделать этого", "Я что похож на садовода?"
        };
        private static readonly string[] PhraseOfRobbers = {
            "Сейчас мы свергнем сдешнего короля!", "Никакой пощады!", "Ты был моим отцом, но отрекся от меня, за это я разрушу твое государство!",
            "=-=/*-+{}0([//}]!", "Let's Dance!", "Я глава культа ягненка подчинитесь мне!", "За сатану!", "Стоп, мы не там очутились...\nДа и пофиг! >=)",
            "Четыре пацана как гонь и вода!", "AREST THIS BASTARDS!",
        };
        private static readonly string[] PhraseOfInhabitantsOfTheDungeon = {
            "Я готов сражатся за вашу честь король!", "I'm Billye Herington", "Я опытный воин, и стану рыцарер!", "Моего деда звали Сталин!",
            "Прям как в гильдии! Идем в Данжи!", "Я охотник подземелий!", "Это чем-то мне напоминает какой-то недавний культ...", "Стоп, а где Айзек?",
            "It Dead Cells?", "I go to Pakistan", "I'm coming!", "Я тут просто подвигами маюсь", "Ну ты и даешь...\nМеня так еще и в подземелья?", "Я Бог =)", "Я приказываю тебе идти в подземелье!", 
        };
        private static readonly string[] PhraseOfKhights = {
            "Я просто подвигами маюсь...", "ONE PUNCH, HERO DONNA NI TSUYOI YATSU MO CHIPPOKKE NA GAKI DATANN DA", "где-то заиграл опенинг Сайтамы?",
            "I'm Billye Herington", "Я стал рыцерем, хехехе =)", "Hollow Knight?", "Я тут задержусь не на долго...", "Эх, так спать хочется", "А, что, Я СТАЛ РЫЦАРЕМ?",
            "Ну нифига, на мне латы... =)",
        };
        private static readonly string[] PhraseOfInhabitantsOfTheDefenders = {
            "Хехехе, сейчас денежки будут капать, хихихихи", "Я готов служить вам мой величайший король!", "Я посплю на посту, думаю никто не вторгнется...",
            "Где-то я слышал, что встреча с разбойниками тут не редкость?", "Кто я?", "А где латы?", "Ну ничиге себе одна монета в день? Нормально я доволен =)",
        };

        private int days = 1;
        private readonly Random random = new Random();

        private int inhabitants = 0;
        private int Hunger = 100;

        private int EndingZeroHunger { get; set; }

        public static int coffers = 0;
        private int defendsPayments = 0;

        private int LiveUserKingdom = 100;

        private int NumberOfDefenders = 0;
        private int DamageUserDefenders;

        private int LiveRobbers;
        private int DamageRobbers;

        public static int Ending { get;  private set; }
        

        private static string userName { get; set; }

        private string UserChoice { get; set; }

        private int HarvestedFood { get; set; }

        private int doingForHunger;

        private int defaultDoingForHunger = 10;

        private readonly string[] namesKnightForEnd = {"Самуель", "Гасс"};

        public Game()
        {
            ForeGroundColor.SetColorBase();
            Console.Write("Введите имя: ");
            userName = Console.ReadLine();
            Thread.Sleep(300);
            Console.WriteLine($"Привет {userName}!");
            ConsoleClear.Clear();
            Ending = 0;
        }

        private void MainLogics(int positionCursorX = 0, int positionCursorY = 0, int countInhabitants = 0) // завтра сделать логику игры, у нас для сюжета есть файл в котором я подробно описал логику и сюжет игры, а теперь это завтра надо сделать в коде!
        {
            positionCursorX = 99;
            positionCursorY = 0;
            while (true)
            {

                if (GoInTheDungeons.NumberOfSuccessfulTrips == 5)
                {
                    string UserChoiceForEnd;

                    int userEnding = random.Next(1,2);
                    ConsoleClear.Clear();

                    Console.Write("Вы сумели пройти пять подземелий!");
                    Console.ReadLine();

                    Console.Write("Все жители рады этому!");
                    Console.ReadLine();

                    Console.Write("Но, теперь у вас стоит выбор кого же поставить на пост короля место вас?");
                    Console.ReadLine();

                    Console.Write("Что же сейчас вам придется выбрать, но выбирайте с умом!");
                    Console.ReadLine();

                    Console.Write($"1. {namesKnightForEnd[0]} | 2. {namesKnightForEnd[1]}");

                    Console.WriteLine();

                    UserChoiceForEnd = Console.ReadLine();

                    if (UserChoiceForEnd == "1")
                    {
                        if (userEnding == 1)
                        {
                            ConsoleClear.Clear();

                            Console.Write("Вы передали пост этому рыцарю...");
                            Console.ReadLine();
                            Console.Write("Вы надеетесь, что передали пост в хорошие руки...");
                            Console.ReadLine();

                            Console.Write("Вы собрали вещи и отправились в долгий путь по миру...");
                            Console.ReadLine();

                            Loading.PrintLoading();

                            Console.Write("Прошло 2 года...");
                            Console.ReadLine();

                            Console.Write("Вы возврощаетесь в свой старый дом...");
                            Console.ReadLine();
                            Console.Write("Прибыв в город вы никого не видите");
                            Console.ReadLine();
                            Console.Write("Пройд во владения короля, вы были в шоке от увиденого!");
                            Console.ReadLine();
                            Console.Write("Вы увидели мертвого короля, и записка на нем...");
                            Console.ReadLine();
                            Console.Write($"На записке было написанно: {userName} ты следующий...");
                            Console.ReadLine();
                            Console.Write("Вы не понимаете, что происходит и в панике не понимаете, что делать...");
                            Console.ReadLine();
                            Console.Write("В какой-то момент, вы чуствуете, что вас что-то проткнуло, это был клинок...");
                            Console.ReadLine();
                            Console.Write("Вы не понимаете, но почему?...");
                            Console.ReadLine();
                            Console.Write("Перед смертью, убийца сказал вам: Передаю привет с другого государства, вы и ваше поледователи были проблемой для госудраства Хасима, и нам пришлось разрушить это государтсво...");
                            Console.ReadLine();
                            Thread.Sleep(1500);

                            ConsoleClear.Clear();
                            Ending = 1;
                            break;
                        }
                        else
                        {
                            ConsoleClear.Clear();

                            Console.Write("Вы передали посту этому рыцарю...");
                            Console.ReadLine();
                            Console.Write("Вы надеетесь, что все будет хорошо также, как и при вашем правлении...");
                            Console.ReadLine();
                            Console.Write("Вы собрали вещи и отправились в долгий путь по миру...");
                            Console.ReadLine();

                            Loading.PrintLoading();

                            Console.Write("Прошло 2 года...");
                            Console.ReadLine();
                            Console.Write("Вы решили вернутся в свой старый дом...");
                            Console.ReadLine();
                            Console.Write("Вы видите оборонительных стенах стражу...");
                            Console.ReadLine();
                            Console.Write("Вас впускают в город и вы видите, что город живет своей жизнью...");
                            Console.ReadLine();
                            Console.Write("Люди живут и радуются жизни, вы видите прилавки на которых выставлена еда, а также в далеке видите кузницу");
                            Console.ReadLine();
                            Console.Write("Гуляя по городу вы видите, что в вашу сторону идет " + namesKnightForEnd[0] + " и вы идете ему на встречу...");
                            Console.ReadLine();
                            Console.Write("Вы шли по городу и он рассказывал вам как ему было тяжело первый год правления, но он справился...");
                            Console.ReadLine();
                            Console.Write("Вам понравилось здесь и вы решили остатся в этом государстве и прожить здесь всю оставшуюся жизнь...");
                            Console.ReadLine();

                            Thread.Sleep(1500);

                            ConsoleClear.Clear();

                            Ending = 3;
                            break;
                        }
                    }
                    else
                    {
                        if (userEnding == 1)
                        {
                            ConsoleClear.Clear();

                            Console.Write("Вы передали посту этому рыцарю...");
                            Console.ReadLine();
                            Console.Write("Вы надеетесь, что все будет хорошо также, как и при вашем правлении...");
                            Console.ReadLine();
                            Console.Write("Вы собрали вещи и отправились в долгий путь по миру...");
                            Console.ReadLine();

                            Loading.PrintLoading();

                            Console.Write("Прошло 4 года...");
                            Console.ReadLine();
                            Console.Write("Подъезжая к государству вы видите, что перед воротами стоит стража...");
                            Console.ReadLine();
                            Console.Write("У вас спросили пропуск, но у вас не было никакого пропуска, они поняли, что вы не местный и впустили вас, но зобрали все ваши вещи");
                            Console.ReadLine();
                            Console.Write("Вы увидели, что город живет своей жизнью, в одной части, что-то продают в другой что-то делают");
                            Console.ReadLine();
                            Console.Write("Вы рады, что ваше бывшее государство не разрушенно...");
                            Console.ReadLine();
                            Console.Write("И тут вы видите короля идущего вместе с кем-то и что-то очень серьезно обсуждающего...");
                            Console.ReadLine();
                            Console.Write(namesKnightForEnd[1] + " увидел вас и обрадывался, что вы вернулись, он рассказал вам какая сейчас обствановка в городе, что происходит, как в принципе обстоят дела..." );
                            Console.ReadLine();
                            Console.Write("Он вам предложил остатся в своем старом государстве и предложил вам очень хороший дом и высоко оплачеваемую работу...");
                            Console.ReadLine();
                            Console.Write("Вы с радостью согласились и остались жить в этом государстве...");
                            Thread.Sleep(1500);
                            ConsoleClear.Clear();

                            Ending = 3;
                            break;

                        }
                        else
                        {
                            ConsoleClear.Clear();

                            Console.Write("Вы передали посту этому рыцарю...");
                            Console.ReadLine();
                            Console.Write("Вы надеетесь, что все будет хорошо также, как и при вашем правлении...");
                            Console.ReadLine();

                            Console.Write("Он позвал вас к себе...");
                            Console.ReadLine();
                            Console.Write("И сказал вам, что вы всегда ему не нравились...");
                            Console.ReadLine();
                            Console.Write("Вы не понимаете, что здесь происходит");
                            Console.ReadLine();
                            Console.Write("Он резко достает меч из своих ножн и...");
                            Console.ReadLine();
                            Console.Write("И направляет на вас...");
                            Console.ReadLine();
                            Console.Write("После этого он начал смеятся, вы не поняли, что происходит и начали тоже смеятся...");
                            Console.ReadLine();
                            Console.Write("Он перестал смеятся и одним махом меча отрубил вам голову...");
                            Console.ReadLine();
                            Console.Write("Вы умерли...");
                            Thread.Sleep(1500);
                            ConsoleClear.Clear();

                            Ending = 1;
                            break;
                        }
                    }
                }


                SetCursorPosition.CursorPosition(positionCursorX, positionCursorY);
                Console.Write($"День {days}");
                Console.ReadLine();

                Console.WriteLine();
                Console.Write("Жителей: " + inhabitants);
                Console.ReadLine();

                Console.Write($"Общий сытость народа: {Hunger}/100");
                Console.ReadLine();

                Console.Write($"Ваши деньги: {coffers}");
                Console.ReadLine();

                Console.Write($"Плата стражникам: {defendsPayments}");
                Console.ReadLine();

                Console.Write("Количество стражников: " + NumberOfDefenders);
                Console.ReadLine();


                if (Hunger <= 0) // если голод упал до нуля сделать, что если у вас нет еды и прошел день после, того как еда кончилась, то это приведет к простой плохой концовке
                {
                    if (EndingZeroHunger == 1) // Концовка
                    {
                        Loading.PrintLoading();

                        Console.Write("Вы не добыли еды...");
                        Console.ReadLine();

                        Console.Write("Все ваши жители и вы умерли от голода...");
                        Console.ReadLine();

                        Console.Write("Вот нельзя было сходить за едой?");
                        Console.ReadLine();

                        Thread.Sleep(1000);
                        ConsoleClear.Clear();

                        Console.WriteLine("Это одна из простых концовок игры, конечно же она плохая =(");
                        Console.ReadLine();

                        Console.WriteLine("Эта концовка не считается за сюжетную коцвоку игры, но вы тут тоже можете закончить игру =)");
                        Console.ReadLine();

                        Console.WriteLine($"Приятно было смотреть как вы выживаете эти {days} дней =)");
                        Console.ReadLine();

                        Console.WriteLine("Я бы хотел еще посмотреть как вы управляете государтвом...");
                        Console.ReadLine();

                        Ending = 2;
                        break;

                    }

                    ConsoleClear.Clear();

                    Console.Write("У вас есть ровно день, чтобы добыть еды, иначе все умрут!!!");
                    Console.ReadLine();

                    Console.Write("Удачи!");
                    Console.ReadLine();

                    ConsoleClear.Clear();

                    EndingZeroHunger = 1;


                }
                else
                    EndingZeroHunger = 0;

                if (days % 2 == 0 || days == 1)
                {
                    NewInhabitants(); // метод добавления нового жителя в строй
                }
                
                if (days % 10 == 0) // если дней прошло 5, то разбойники нападают...
                {
                    Ending = RobbersAttack(); // метод нападения разбойников на государство

                    if (Ending == 2)
                    {
                        Thread.Sleep(1000);
                        ConsoleClear.Clear();
                        Console.WriteLine("Это одна из простых концовок игры, конечно же она плохая =(");
                        Console.ReadLine();

                        Console.WriteLine("Эта концовка не считается за сюжетную коцвоку игры, но вы тут тоже можете закончить игру =)");
                        Console.ReadLine();

                        Console.WriteLine($"Приятно было смотреть как вы выживаете эти {days} дней =)");
                        Console.ReadLine();

                        Console.WriteLine("Я бы хотел еще посмотреть как вы управляете государтвом...");
                        Console.ReadLine();
                        break;
                    }
                        
                }

                Console.WriteLine("Хотите ли кого нибудь отправить в хозяйтсво?");
                Console.WriteLine("1. Да | 2. Нет");
                UserChoice = Console.ReadLine();

                if (UserChoice == "1") // если пользователь хочет кого-то отправить в хозяйтсво
                {
                    Thread.Sleep(600);
                    ConsoleClear.Clear();
                    doingForHunger = random.Next(10, 50);

                    Console.Write("Ваше количество жителей состовляет: " + inhabitants);
                    Console.ReadLine();

                    Console.Write("Какое количество жителей выхотите отправить в хозяйтсво?");
                    Console.ReadLine();

                    Console.Write("Введите число: ");
                    int.TryParse(Console.ReadLine(), out countInhabitants);

                    Console.Write($"{countInhabitants} жителей отправились на сбор еды");
                    Console.ReadLine();

                    Console.Write("Вы слышите разговор жителей которых отправили за сбором еды, и вот что вы слышате: " + PhraseOfInhabitantsOfTheEconomy[random.Next(0, PhraseOfInhabitantsOfTheEconomy.Length - 1)]);
                    Console.ReadLine();

                    Ending = LootFood();
                    if (Ending != 2) // двойка означает что мы попались на простую концовку, если не двойка значит все хорошо =)
                    {


                        Console.Write($"Ваши жители пришли и принесли {HarvestedFood}");
                        Console.ReadLine();
                        Console.Write("Вы теперь сможите прожить больше чем предпологалось мной, вам повезло =)");
                        Console.ReadLine();
                        Hunger -= doingForHunger;
                        Console.Write($"Поход за едой у вас потратил {doingForHunger} еды");
                        Console.ReadLine();
                        Console.Write("В конце дня принесенная вами еда востановить не достающие очки сытости");
                        ConsoleClear.Clear();
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        ConsoleClear.Clear();
                        Console.WriteLine("Вам попалась самая грустная по-моему мнению простоя концовка... =(");
                        Console.ReadLine();

                        Console.Write("Это одна из простых концовок игры, конечно же она плохая =(");
                        Console.ReadLine();

                        Console.WriteLine("Эта концовка не считается за сюжетную коцвоку игры, но вы тут тоже можете закончить игру =)");
                        Console.ReadLine();

                        Console.WriteLine($"Приятно было смотреть как вы выживаете эти {days} дней =)");
                        Console.ReadLine();

                        Console.WriteLine("Я бы хотел еще посмотреть как вы управляете государтвом...");
                        Console.ReadLine();

                        break;
                    }
                }
                else
                {
                    Thread.Sleep(600);
                    Console.Clear();
                    Console.Write("Хотите ли вы чтобы какое-то количество ваших подчиненных стало стражей вашего города и охраняло его?");
                    Console.ReadLine();

                    Console.WriteLine("1. Да | 2. Нет");
                    UserChoice = Console.ReadLine();

                    if (UserChoice == "1") // проверка если пользователь хочет отправить жителей в стражники
                    {
                        Thread.Sleep(600);
                        ConsoleClear.Clear();
                        Console.Write("Учтите, что если вы выставите на стражу какое-то количество жителей, то они там останутся на всегда");
                        Console.ReadLine();

                        Console.Write("Кто находится на посту в стражниках навсегда там и останется, потому что это его судьба!");
                        Console.ReadLine();

                        Console.Write("По этому распределяйте своих подчиненых в стражу с умом!");
                        Console.ReadLine();

                        Console.Write("Чуть не забыл стражники как и обычные жители потребляют еду, но еще просят за то, что они стоят на посту по одной монете в день, и не важно сколько будет стражников, цена не изменится!");
                        Console.ReadLine();

                        Console.Write("Ваше количество жителей: " + inhabitants);
                        Console.ReadLine();

                        Console.Write("Сколько жителей вы хотите отправить в стражники?");
                        Console.ReadLine();

                        Console.Write("Введите число: ");
                        int.TryParse(Console.ReadLine(), out countInhabitants);

                        Console.WriteLine($"{countInhabitants} жителей станут стражниками и утратят статус жителя");
                        Console.ReadLine();

                        Console.Write("Стоимость содержания стражников составляет одна монета в день!");
                        doingForHunger = random.Next(5, 20);
                        Hunger -= doingForHunger;

                        Console.Write($"Служба на посту потратит {doingForHunger} сытости!");
                        Console.ReadLine();

                        NumberOfDefenders += countInhabitants;
                        DamageUserDefenders += countInhabitants;
                        inhabitants -= countInhabitants;

                        defendsPayments = countInhabitants / 2;

                        Console.Write("Жители отправленные в стражники идут и говорят: " + PhraseOfInhabitantsOfTheDefenders[random.Next(0, PhraseOfInhabitantsOfTheDefenders.Length - 1)]);
                        Console.ReadLine();
                        ConsoleClear.Clear();
                    }
                    else // если нехочет отправлять в стражники возможно он хочет кого нибудь отправить в данж
                    {
                        Thread.Sleep(600);
                        ConsoleClear.Clear();
                        Console.Write("Хотите ли вы кого-нибудь отправить в данж?");
                        Console.ReadLine();

                        Console.WriteLine("1. Да | 2. Нет");
                        UserChoice = Console.ReadLine();

                        if (UserChoice == "1")
                        {
                            Thread.Sleep(600);
                            ConsoleClear.Clear();
                            Console.Write("Выберите количество подчиненных которых вы хотите отправить в данж...");
                            Console.ReadLine();

                            Console.Write("Введите количество: ");
                            int.TryParse(Console.ReadLine(), out countInhabitants);

                            Console.Write($"{0} жителей вы отправили в данж");
                            Console.ReadLine();
                            Console.Write("Перед уходом они о чем-то вели разговор и вы его услышали, в разговори говорилось: " + PhraseOfInhabitantsOfTheDungeon[random.Next(0, PhraseOfInhabitantsOfTheDungeon.Length - 1)]);
                            Console.ReadLine();
                            Console.Write("Сейчас вы перейдете в процесс данжа");
                            Console.ReadLine();
                            Console.Write("Это отдельный проработанный вид игры, где вам предствоит пройти вашими жителями весь данж, и в какой-то из комнат будет босс, пройдя данж и одолев босса, ваши жители станут рыцарями и вернутся домой!");
                            Console.ReadLine();
                            Console.Write("Подожди скоро все начнется...");
                            Console.ReadLine();
                            ConsoleClear.Clear();
                            Loading.PrintLoading();

                            GoInTheDungeons userGoInDungeon = new GoInTheDungeons(countInhabitants); // завтра проработать логику данжей, а на сегодня пока, что хватит =) ты молодец!

                            userGoInDungeon.ResultOfTheDungeon();

                            if (userGoInDungeon.FailedTrips == 1) // пользователь не прошел данж и словил плохую простую концовку
                            {
                                ConsoleClear.Clear();

                                Console.Write("Это одна из простых плохих концовок =)");
                                Console.ReadLine();
                                Console.Write("Эта концовка не считается за сюжетную концовку, но даже в данже вы можете умереть и словить одну из простых концок =)");
                                Console.ReadLine();
                                Console.Write("Мне понравилось как вы закончили игру...");
                                Console.ReadLine();
                                Console.Write($"Вы прожили {days} дней");
                                Console.ReadLine();
                                Console.Write("Мн бы хотелось взгялнуть, сможете ли вы вообще пройти игру на сюжетную концовку =)");
                                Console.ReadLine();
                                Console.Write("Хахаха, наверное такого не будет...");

                                Ending = 2;

                                break;
                            }
                            else
                            {
                                ConsoleClear.Clear();

                                Console.Write("Ого, вы смогли пройти данж!");
                                Console.ReadLine();

                                Console.Write("Вы сумели победить босса!");
                                Console.ReadLine();

                                Console.Write("Голод который тратится, на ничего не делая уменьшается на единицу!");
                                Console.ReadLine();

                                defaultDoingForHunger--;
                                Console.Write($"Вы прошли {GoInTheDungeons.NumberOfSuccessfulTrips} подземелий из {5} нужных подземелий!");
                                Console.ReadLine();

                                Console.Write("Платить вам больше не будут =)");
                                Console.ReadLine();

                                Console.Write("Но я этого обещал верно?");
                                Console.ReadLine();

                                Console.Write("Жители рады, что вы сумели пройти данж и ваших солдат сделали рыцарями!");
                                Console.ReadLine();

                                Console.Write("Вы рады этому, но к вам подходят все ваши жители, и от всего города они хотят вас отблагодарить, за хорошее правление...");
                                Console.ReadLine();

                                Console.Write("И дают вам целых 40 монет!");
                                Console.ReadLine();

                                Console.Write("В честь этого вашим солдатам будет построена церковь...");
                                Console.ReadLine();

                                Console.Write("Вы не сможете пользоватся, этими солдатами, так как они отслужили свое и теперь хоятт жить мирно...");
                                Console.ReadLine();

                                Console.Write("Но это не конец игры, вам также придется еще ходить в данж и играть в эту игру =)");
                                Console.ReadLine();

                                Console.Write("Что же желаю удачи в дальнейшем прохождении!");
                                Console.ReadLine();

                                Thread.Sleep(300);
                                ConsoleClear.Clear();
                                int userwin = 40;
                                coffers += userwin;
                            }

                        }
                        else // если даже не в данж, то день проходит спокойно...
                        {
                            Thread.Sleep(400);
                            ConsoleClear.Clear();
                            Console.Write("Вы просто решили провести день ничего не делая...");
                            Console.ReadLine();

                            Console.Write("Ваши жители тоже ничего не делали...");
                            Console.ReadLine();

                            Console.Write("Сража стояла на посту вам придется им платить...");
                            Console.ReadLine();

                            Console.Write("А также, даже если вы ничего и не делали, кушать то, все равно хочется...");
                            Console.ReadLine();

                            Console.Write($"Вы потратили {defaultDoingForHunger} сытости на этот день");
                            Console.ReadLine();

                            Console.Write("День скоро закончится так, что можете просто отдохнуть...");
                            Console.ReadLine();

                            Thread.Sleep(1500);
                            Hunger -= defaultDoingForHunger;
                            ConsoleClear.Clear();
                        }
                    }
                }

                Console.Write("День подходит к концу...");
                Console.ReadLine();
                Console.Write("Завтра будет что-то новое...");
                Console.ReadLine();
                Console.Write($"Ваше имущество состовляет: {coffers} | без учета платы стражи");
                Console.ReadLine();
                days++;
                Hunger += HarvestedFood; // голод, и количество которое мы добыли
                HarvestedFood -= HarvestedFood;
                coffers -= defendsPayments;
                coffers += inhabitants;
                ConsoleClear.Clear();
            }
        }

        private int LootFood(int ending = 0) // метод добычи еды, а также исходные концовки в случае, если кто-то из отправленных заразится смертельной болезнью
        {
            ConsoleClear.Clear();
            int Infections = random.Next(0, 1);

            if (Infections == 1)
            {
                Console.WriteLine("Вам доложили о приближении ваших жителей, вы размыто видите их, но не понимаете, что с ними, они выглядят подавленными");
                Console.ReadLine();

                Console.Write("Как жители зашли в город большинство из них просто упало...");
                Console.ReadLine();

                Console.Write("Их отправили к врачу, но подороге стражники которые несли их тоже упали...");
                Console.ReadLine();

                Console.Write("Все кто был поблизости к пришедщим жителям тоже упали...");
                Console.ReadLine();

                Console.Write("Вы не понимаете что происходит, к вам подбегает один из жителей, и рассказывает что на упавших людях были какие-то странные вулдыри и что они все кашляли и выглядели больными...");
                Console.ReadLine();

                Console.Write("Вы замечаете на этом человеке тоже, что-то похожее");
                Console.ReadLine();

                Console.Write("Вы в страхе отталкиваете, его и убегаете");
                Console.ReadLine();

                Console.Write("Бежа по лестнице вас схватывает странная боль по всему телу, вы останавливаетесь...");
                Console.ReadLine();

                Console.Write("Вы останавливаетесь и вам становится жарко итяжело дышать");
                Console.ReadLine();

                Console.Write("Вы садитесь на ступеньки и облакачиваетесь об стену, вы покашляли и увидели кровь...");
                Console.ReadLine();

                Console.Write("По итогу вы поняли, что жители принесли смертельную болезнь");
                Console.ReadLine();

                Console.Write("ХАХАХАХАХА");
                Console.ReadLine();

                Console.Write("Вам стало смешно, вам хочется спать, и с улыбкой на лице вы засыпаете...");
                Console.ReadLine();

                Console.Write("Вы умерли от смертельной болезни, которую никто не ожидал...");
                Console.ReadLine();

                Console.Write($"Вы прожили и управляли своим государством {days} дней");
                Console.ReadLine();

                ConsoleClear.Clear();
                ending = 2;
                return ending;
            }
            else
            {
                HarvestedFood = random.Next(0, 50);
                Console.Write("В далеке вы видите возвращающихся жителей с едой, вы видите по их тело движениям, что у них все хорошо");
                Console.ReadLine();

                Console.Write("Вы ждете прихода жителей в город...");
                Console.ReadLine();

                Thread.Sleep(1500);
                ConsoleClear.Clear();
            }
            


            return ending;
        }

        private void NewInhabitants() // метод добавления нового жителя в течение каждых треъ дней, прмходит один новый житель
        {
            ConsoleClear.Clear();
            Thread.Sleep(300);
            Console.Write("Ого, к вам похоже пришел новый житель!");
            Console.ReadLine();
            ConsoleClear.Clear();
            Console.Write($"Спутник: {PhraseOfNewResidents[random.Next(0, PhraseOfNewResidents.Length - 1)]}");
            Console.ReadLine();
            Console.Write("Сейчас перед вами встанет выбор просто выберите цифру и введите ее =)");
            Console.ReadLine();
            Console.Write("Хотите ли принять спутника?");
            Console.ReadLine();
            Console.WriteLine("1. Да | 2. Да");
            string userChoice = Console.ReadLine();
            if (userChoice == "1" || userChoice == "2")
                inhabitants++;
            else
                inhabitants++;

            Console.Write("Вы приняли нового жителя");
            Console.ReadLine();
            Console.Write("Скоро вам предствоить выбирать, что вы сегодня будите делать =)");
            Console.ReadLine();
            Console.Write("Удачи!");
            Thread.Sleep(500);
            ConsoleClear.Clear();
        }

        private int RobbersAttack(int ending = 0) // метод атаки разбойников и исходные простые концовки в случае поражения
        {
            ConsoleClear.Clear();
            Console.WriteLine("Вы слышите чьи-то голоса и вот, что они говорят: " + PhraseOfRobbers[random.Next(0, PhraseOfRobbers.Length - 1)]);
            Console.ReadLine();
            Console.WriteLine("О НЕТ!");
            Console.ReadLine();
            Console.WriteLine("На вас напали разбойники!");
            Console.ReadLine();
            Console.WriteLine("Защищайтесь!!!!");
            Thread.Sleep(1000);
            ending = Attack();

            return ending;

            int Attack(int end = 0)
            {
                if (NumberOfDefenders > 0)
                {
                    LiveRobbers = random.Next(1, inhabitants);
                    DamageRobbers = random.Next(0, inhabitants);

                    for (; LiveRobbers > 0 && LiveUserKingdom > 0;)
                    {
                        Console.WriteLine("Очки здоровья разбойников: " + LiveRobbers);

                        Thread.Sleep(1000);

                        Console.WriteLine();
                        Console.WriteLine("Очки здоровья вашего государства: " + LiveUserKingdom);

                        Thread.Sleep(1000);

                        ConsoleClear.Clear();
                        Console.WriteLine("Разбойники нападают!!!");

                        Thread.Sleep(1500);

                        Console.WriteLine("Удар разбойников!");

                        Thread.Sleep(1500);

                        ForeGroundColor.SetColorForHit();
                        Console.WriteLine("-_/-+[]");
                        LiveUserKingdom -= DamageRobbers;
                        Thread.Sleep(1500);

                        ForeGroundColor.SetColorBase();
                        Console.WriteLine("Урон разбойников: " + DamageRobbers);
                        Thread.Sleep(2000);

                        Console.WriteLine("Ваши подчиненные стоящие в защите нападают на разбойников!");
                        Thread.Sleep(1000);
                        Console.WriteLine("Они наносят удар по разбойникам!");
                        Thread.Sleep(1000);
                        ForeGroundColor.SetColorForHit();
                        Console.WriteLine("-_/-+[]");
                        LiveRobbers -= DamageUserDefenders;
                        Thread.Sleep(1000);

                        ForeGroundColor.SetColorBase();

                        Console.WriteLine("Следующий раунд!");
                        Console.ReadLine();

                        ConsoleClear.Clear();
                    }

                    if (LiveRobbers > 0 && LiveUserKingdom <= 0)
                    {
                        Loading.PrintLoading();
                        Thread.Sleep(700);
                        Console.Write("Разбойники убили вашу стражу!");
                        Console.ReadLine();

                        Console.Write("Они разграбили ваше государство и убили всех кто в нем был, вы потерпели поражение в стражении с разбойниками");
                        Console.ReadLine();

                        Console.Write("Они также убили вас, но в последние секунды вашей жизни, вы небыли разочарованны тем, что произошло, но и не рады");
                        Console.ReadLine();

                        Console.Write($"Вы прожили и управляли своим государством {days} дней");
                        Console.ReadLine();

                        ConsoleClear.Clear();
                        end = 2;
                        return end;
                    }
                    else if (LiveUserKingdom > 0 && LiveRobbers <= 0)
                    {
                        Thread.Sleep(700);
                        ConsoleClear.Clear();
                        Console.WriteLine("Вам удалось отбится от атаки разбойников!");
                        Console.ReadLine();

                        Console.WriteLine("К счастью никто не умер, но есть раненные, но это не проблема их вылечат");
                        Console.ReadLine();

                        Console.WriteLine("Щдоровье вашего государства после боя состовляет: " + LiveUserKingdom);
                        Console.ReadLine();

                        Console.WriteLine("Оно востановится само, вам об этом переживать не нужно");
                        Console.ReadLine();

                        Console.WriteLine("Граждане рады, что у них такой хороший король, что смог предотвратить разруху государства!");
                        Console.ReadLine();

                        Console.WriteLine("Они благодорят вас!");
                        Console.ReadLine();

                        ConsoleClear.Clear();
                        end = 0;
                        return end;
                    }
                }
                else
                {
                    ConsoleClear.Clear();
                    Thread.Sleep(700);
                    Console.Write("У вас никого не было в защите и разбойники без каких либо усилий варвались в ваше государство");
                    Console.ReadLine();

                    Console.Write("Они разграбили ваше государтсво, и у всех жителей на виду отрубили вам голову");
                    Console.ReadLine();

                    Console.Write("Перед смертью вы жалели, что не поставили никого на горизонт...");
                    Console.ReadLine();

                    Console.Write("Вы умерли как благородный человек, но как плохой король...");
                    Console.ReadLine();
                    end = 2;
                    return end;
                }
                return 0;
            }
            
        }

        public void ResultateLogics()
        {
            MainLogics();
        }
    }

    static partial class Loading // partial класс с логикой загрузки
    {
        private static int x = 9;
        private static int y = 0;
        private static string load = "Loading...";
    }

    static class ConsoleClear // класс для того чтобы отчищать консоль, если нам это потребуется
    {
        public static void Clear()
        {
            Console.Clear();
        }
    }

    static class ForeGroundColor
    {
        public static void SetColorBase()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void SetColorForHit()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }

        public static void SetColorForDungeon()
        {
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void SetColorForDungeonHit()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
    }
}
