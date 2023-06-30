using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace private_project
{
    public class Program
    {
        static void Main(string[] args) 
        {
            //라운드,스테이지 변수생성
            int round = 1;
            int stage = 1;

            //플레이어 생존여부확인변수
            bool live = true;
            //UI객체 생성
            UI UI1 = new UI();
            //플레이어 생성,초기화
            Player albert = new Player();
            albert.IntiailizePlayer("알버트", "주먹도끼", 30, 400, 400, 10, 150, 1);
            //상점 on 변수
            bool shopOn = true; 
            //공룡 초기화
            List<dinosaur> dinosaurs = new List<dinosaur>();
            dinosaur normal1 = new dinosaur();
            normal1.InitDinosaur("트리케라톱스", 200, 200, 20, 10, "초식공룡", 50);
            dinosaurs.Add(normal1);
            dinosaur normal2 = new dinosaur();
            normal2.InitDinosaur("브라키오사우루스", 200, 200, 30, 5, "초식공룡", 50);
            dinosaurs.Add(normal2);
            dinosaur boss1 = new dinosaur();
            boss1.InitDinosaur("벨로시랩터", 300, 300, 30, 40, "육식공룡", 1000);
            dinosaurs.Add(boss1);
            dinosaur normal4 = new dinosaur();
            normal4.InitDinosaur("파라사우롤로푸스", 200, 200, 30, 10, "초식공룡", 80);
            dinosaurs.Add(normal4);
            dinosaur normal5 = new dinosaur();
            normal5.InitDinosaur("스테고사우루스", 200, 200, 30, 10, "초식공룡", 60);
            dinosaurs.Add(normal5);
            dinosaur boss2 = new dinosaur();
            boss2.InitDinosaur("티라노사우루스", 300, 300, 50, 10, "육식공룡", 1000);
            dinosaurs.Add(boss2);
            dinosaur normal7 = new dinosaur();
            normal7.InitDinosaur("알로사우루스", 300, 300, 40, 10, "육식공룡", 90);
            dinosaurs.Add(normal7);
            dinosaur normal8 = new dinosaur();
            normal8.InitDinosaur("안킬로사우루스", 400, 400, 30, 10, "초식공룡", 40);
            dinosaurs.Add(normal8);
            dinosaur boss3 = new dinosaur();
            boss3.InitDinosaur("프테라노돈", 300, 300, 40, 40, "육식공룡", 70);
            dinosaurs.Add(boss3);
            dinosaur boss4 = new dinosaur();
            boss4.InitDinosaur("기가노토사우루스", 600, 600, 100, 20, "육식공룡", 1000);
            dinosaurs.Add(boss4);
            //원주민리스트생성
            List<PrimitiveMan> mans = new List<PrimitiveMan>();
            PrimitiveMan man1 = new PrimitiveMan();
            man1.InitPrimitive("원시인", 100, 100, 30, 10, 20, 50);
            mans.Add(man1);
            PrimitiveMan man2 = new PrimitiveMan();
            man2.InitPrimitive("식인종", 150, 150, 30, 10, 20, 20);
            mans.Add(man2);
            //shop객체생성
            Shop shop = new Shop();

            //랜덤객체 생성
            Random rnd = new Random();
            //스테이지 랜덤값을 담을 temp변수
            int temp;
            
            //공룡인덱스 변수
            int dinoIdx = 0;
            //원주민 랜덤인덱스 변수
            int tempPrimitive;
            //공룡 싸울확률 변수
            int tempDinoBattle;
           
            //start screen 출력
            //UI출력
            UI1.MakeUI();
            UI1.PrintStartScreen();
            ConsoleKeyInfo input = Console.ReadKey();
            Console.Clear();
            Task.Delay(1000).Wait();

            UI1.MakeUI();
            UI1.Synopsis();
            //UI출력
            UI1.MakeUI();
            while (true)
            {
              
                temp = rnd.Next(0, 101);
                tempPrimitive = rnd.Next(0, 2);
                tempDinoBattle = rnd.Next(0, 101);

                //기본스크립트 출력
                Console.Clear();
                UI1.PrintRoundStart();
                UI1.PrintStage(stage, round);
                UI1.Printstate(albert);
                UI1.PrintDesert();
                
                ConsoleKeyInfo inputy = Console.ReadKey();
                if (inputy.KeyChar == 'R')
                {
                    Console.Clear();
                    UI1.PrintEggs(albert);
                    ConsoleKeyInfo inputx = Console.ReadKey();
                    Console.Clear();
                    UI1.PrintRoundStart();
                    UI1.PrintStage(stage, round);
                    UI1.Printstate(albert);
                    UI1.PrintDesert();
                    Task.Delay(1000).Wait();
                }
               

                Task.Delay(1000).Wait();
                if (!(stage%4 ==0))
                {// 스테이지가 4의 배수가 아니면서
                    if (temp <= 50)
                    {
                        tempDinoBattle = rnd.Next(0, 101);
                        Task.Delay(1000).Wait();
                        live = BattleDino(dinosaurs[dinoIdx], ref albert, ref UI1, stage, round, tempDinoBattle);
                        round++;
                        dinoIdx++;
                        if (live == false)
                        {
                            Console.WriteLine("게임에서 패배했습니다. 다시 도전해주세요.");
                            break;
                        }
                    }
                    else if (temp > 50 && temp <= 80)
                    {
                        //원주민
                        if (tempPrimitive == 0)
                        {
                            MeetPrimitive(mans[0], ref albert, ref UI1, stage, round);
                            round++;
                        }
                        else if (tempPrimitive == 1)
                        {
                            live = BattlePrimitive(mans[1], ref albert, ref UI1, stage, round);
                            if (live == false)
                            {
                                Console.WriteLine("게임에서 패배했습니다. 다시 도전해주세요.");
                                break;
                            }
                            round++;
                        }
                    }
                    else
                    {
                        //화산폭발
                        MeetDisaster(ref albert, ref UI1, stage, round);
                        round++;
                        if (albert.hp <= 0)
                        {
                            Console.WriteLine("게임에서 패배했습니다. 다시 도전해주세요.");
                            break;
                        }
                    }
                }
                else if (stage %4 ==0)//라운드가 1이라면
                {
                    Console.Clear();
                    UI1.MakeUI();
                    UI1.PrintStage(stage, round);
                    UI1.Printstate(albert);
                    //상점 구현
                    round++;
                    shop.InitializeItem();
                    shop.firstscript();
                    shop.PrintShop();
                    /* albert.PrintInventory();*/
                    shop.PrintCursorPosition();
                    shop.Buy(UI1,albert);
                    shopOn = false;
                    Console.ReadLine();
                }
                if (albert.eggCount % 4 == 0)
                {
                    stage++;
                    round = 1;
                    shopOn = true;
                }


                if (albert.eggCount == 11)
                {
                    //엔딩출력
                    UI1.MakeUI();
                    UI1.PrintEnding();
                    ConsoleKeyInfo Einput = Console.ReadKey();
                    break;
                }
            }




            /*ui01.PrintPlayer();
            ui01.PrintMonster();
            battle.PrintBattleTitle();
            battle.PrintBattleStatement();
            battle.PrintBattleState();*/

            /*시작화면출력
            StartScreen startScreen = new StartScreen();
            startScreen.PrintStartScreen();
            ConsoleKeyInfo input = Console.ReadKey();*/



            Console.SetCursorPosition(0, 38);
        }
        static bool BattleDino(dinosaur array, ref Player albert, ref UI UI1, int stage, int round, int tempDinoBattle)
        {
            bool alive = true;
            Console.Clear();
            UI1.MakeUI();
            UI1.PrintStage(stage, round);
            UI1.Printstate(albert);
            UI1.PrintDesert();
            PrintBattleDinosaur(array);
            if (array.name =="벨로시랩터" || array.name =="티라노사우루스" || array.name =="기가노토사우루스")
            {
                Console.SetCursorPosition(4, 43);
                Console.Write("갑자기 지축이 흔들린다.무언가 엄청난것들이 오고있다!");
                Console.SetCursorPosition(4, 45);
                Console.Write("{0} {1}가 나타났다!!!", array.type, array.name);
                Task.Delay(1000).Wait();
            }
            else
            {
                Console.SetCursorPosition(4, 43);
                Console.WriteLine("풀숲에서 갑자기 {0} {1}가 나타났다!!!", array.type, array.name);
                Task.Delay(1000).Wait();
            }

            Task.Delay(1000).Wait();
            while (true)
            {
                bool check = false;
                PrintBattleDinosaur(array);
                UI1.MakeUI();
                UI1.PrintStage(stage, round);
                UI1.Printstate(albert);
                UI1.PrintDesert();
                albert.PrintPlayer();
                BattleFirstScript(array);
                PrintBattleCursorPosition();

              
                Console.SetCursorPosition(70, 46);
                while (true)
                {
                   
                    ConsoleKeyInfo input1 = Console.ReadKey();
                    switch (input1.Key)
                    {
                        case ConsoleKey.UpArrow:
                            {
                                if (Console.CursorTop == 46)
                                {
                                    Console.SetCursorPosition(70, 50);
                                }
                                else
                                {
                                    Console.SetCursorPosition(70, Console.CursorTop - 2);                              
                                }
                                break;
                            }
                        case ConsoleKey.DownArrow:
                            {
                                if (Console.CursorTop == 50)
                                {
                                    Console.SetCursorPosition(70, 46);

                                }
                                else
                                {
                                    Console.SetCursorPosition(70, Console.CursorTop +2);

                                }
                                break;
                            }
                        case ConsoleKey.Enter:
                            {
                                if (Console.CursorTop == 46)
                                {
                                    if (tempDinoBattle >= array.friendship)
                                    {
                                        Console.Clear();
                                        UI1.MakeUI();
                                        UI1.PrintStage(stage, round);
                                        UI1.Printstate(albert);
                                        UI1.PrintDesert();
                                        Console.SetCursorPosition(4,43);
                                        Console.WriteLine("{0}가 한눈을 팔고있을때 재빨리 움직여야한다...",array.name);
                                        Task.Delay(1000).Wait();
                                        Console.SetCursorPosition(4, 45);
                                        Console.WriteLine("휴 다행히 무사히 알을 가지고 도망쳤다...");
                                        albert.eggCount++;
                                        check = true;
                                        Task.Delay(1000).Wait();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        UI1.MakeUI();
                                        UI1.PrintStage(stage, round);
                                        UI1.Printstate(albert);
                                        UI1.PrintDesert();
                                        Console.SetCursorPosition(4, 43);
                                        Console.WriteLine("이런! 경계심이 강해서 들켜버렸다! 전투가 불가피하다...");
                                        albert.eggCount++;
                                        Task.Delay(1000).Wait();
                                        Battle1(array, albert, ref alive, UI1, ref stage, ref round);
                                        check = true;
                                        break;
                                    }
                                }
                                else if (Console.CursorTop == 48)
                                {   if (albert.playerInventory.Count != 0)
                                    {
                                        for (int i = 0; i < albert.playerInventory.Count; i++)
                                        {
                                            if (albert.playerInventory[i] == "공룡캣닢")
                                            {
                                                Console.Clear();
                                                UI1.MakeUI();
                                                UI1.PrintStage(stage, round);
                                                UI1.Printstate(albert);
                                                UI1.PrintDesert();
                                                Console.SetCursorPosition(4, 43);
                                                Drawleaf(UI1, stage, round, albert);
                                                Console.SetCursorPosition(4, 43);
                                                Console.WriteLine("캣잎향이 은은하게 풍깁니다. {0}의 경계심이 풀어졌습니다.", array.name);
                                                array.friendship -= 40;
                                                albert.playerInventory.RemoveAt(i);
                                                ConsoleKeyInfo input3 = Console.ReadKey();
                                                Console.Clear();
                                                UI1.MakeUI();
                                                UI1.PrintStage(stage, round);
                                                UI1.Printstate(albert);
                                                albert.PrintPlayer();
                                                UI1.PrintDesert();
                                                BattleFirstScript(array);
                                                PrintBattleCursorPosition();
                                                Console.SetCursorPosition(70, 46);
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        UI1.MakeUI();
                                        UI1.PrintStage(stage, round);
                                        UI1.Printstate(albert);
                                        UI1.PrintDesert();
                                        Console.SetCursorPosition(4, 43);
                                        Console.WriteLine("공룡캣닢이 인벤토리에 없습니다.");
                                        ConsoleKeyInfo input3 = Console.ReadKey();
                                        Console.Clear();
                                        UI1.MakeUI();
                                        UI1.PrintStage(stage, round);
                                        UI1.Printstate(albert);
                                        albert.PrintPlayer();
                                        UI1.PrintDesert();
                                        BattleFirstScript(array);
                                        PrintBattleCursorPosition();
                                        Console.SetCursorPosition(70, 46);
                                    }
                                    break;
                                }
                                else if (Console.CursorTop == 50)
                                {
                                    if (albert.playerInventory.Count != 0)
                                    {
                                        for (int i = 0; i < albert.playerInventory.Count; i++)
                                        {
                                            if (albert.playerInventory[i] == "팔팔한생선")
                                            {
                                                Console.Clear();
                                                UI1.MakeUI();
                                                UI1.PrintStage(stage, round);
                                                UI1.Printstate(albert);
                                                UI1.PrintDesert();
                                                Console.SetCursorPosition(4, 43);
                                                Console.WriteLine(" 팔팔한 생선을먹고 HP를 100회복했습니다!");
                                                albert.playerInventory.RemoveAt(i);
                                                albert.hp += 300;
                                                ConsoleKeyInfo input3 = Console.ReadKey();
                                                Console.Clear();
                                                UI1.MakeUI();
                                                UI1.PrintStage(stage, round);
                                                UI1.Printstate(albert);
                                                albert.PrintPlayer();
                                                UI1.PrintDesert();
                                                BattleFirstScript(array);
                                                PrintBattleCursorPosition();
                                                Console.SetCursorPosition(70, 46);
                                                break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        UI1.MakeUI();
                                        UI1.PrintStage(stage, round);
                                        UI1.Printstate(albert);
                                        UI1.PrintDesert();
                                        Console.SetCursorPosition(4, 43);
                                        Console.WriteLine("팔팔한 생선이 인벤토리에 없습니다.");
                                        ConsoleKeyInfo input3 = Console.ReadKey();
                                        Console.Clear();
                                        UI1.MakeUI();
                                        UI1.PrintStage(stage, round);
                                        UI1.Printstate(albert);
                                        albert.PrintPlayer();
                                        UI1.PrintDesert();
                                        BattleFirstScript(array);
                                        PrintBattleCursorPosition();
                                        Console.SetCursorPosition(70, 46);
                                    }
                                    break;
                                }
                                break;
                            }
                    }  
                    if(check == true)
                    {
                        break;
                    }
                }
                if(check ==true)
                {
                    break;
                }
            }
            return alive;
        }

        static bool BattlePrimitive(PrimitiveMan primi, ref Player albert, ref UI UI1, int stage, int round)
        {
            bool alive = true;
            Console.Clear();
            UI1.MakeUI();
            UI1.PrintStage(stage, round);
            UI1.Printstate(albert);
            albert.PrintPlayer();
            UI1.PrintDesert();
            Console.SetCursorPosition(4, 45);
            Console.WriteLine("풀숲에서 갑자기 {0}이 나타났다!!!", primi.name);
            Task.Delay(1500).Wait();
            while (true)
            {
                
                UI1.MakeUI();
                UI1.PrintStage(stage, round);
                UI1.Printstate(albert);
                albert.PrintPlayer();
                UI1.PrintDesert();
                primi.PrintPrimi1();
                if (albert.hp <= 0)
                {
                    alive = false;
                    Console.Clear();
                    break;
                }
                else if (primi.hp <= 0)
                {
                    Console.SetCursorPosition(4, 43);
                    Console.WriteLine("식인종과의 싸움에서 승리하고 화석을 20얻었다.");
                    albert.fossils += 30;
                    Task.Delay(1000).Wait();
                    primi.hp = primi.maxHp;
                    albert.fossils += 20;
                    alive = true;
                    ConsoleKeyInfo input = Console.ReadKey();
                    Console.Clear();
                    break;
                }
                Console.SetCursorPosition(30, 32);
                Console.WriteLine("{0}", primi.name);
                Console.SetCursorPosition(30, 34);
                Console.WriteLine("현재HP  {0}", primi.hp);
                Task.Delay(400).Wait();
                Console.SetCursorPosition(80, 32);
                Console.WriteLine("{0}", albert.name);
                Console.SetCursorPosition(80, 34);
                Console.WriteLine("현재HP  {0}", albert.hp);
                Task.Delay(400).Wait();
                Console.SetCursorPosition(4, 45);
                Console.WriteLine("알버트가 {0}를 {1}로 공격했다.", primi.name, albert.weaponName);
                Task.Delay(400).Wait();
                Console.SetCursorPosition(4, 47);
                Console.WriteLine("{0}의 HP가 {1}만큼 떨어졌다.", primi.name, albert.weaponPower);
                primi.hp = primi.hp - albert.weaponPower;
                Task.Delay(400).Wait();
                Console.SetCursorPosition(4, 49);
                Console.WriteLine("{0}가 알버트를 공격했다.", primi.name);
                Task.Delay(400).Wait();
                Console.SetCursorPosition(4, 51);
                Console.WriteLine("알버트의 HP가 {0}만큼 떨어졌다.", primi.power);
                albert.hp = albert.hp - primi.power;
                Task.Delay(1000).Wait();
            }

            return alive;
        }

        static void MeetPrimitive(PrimitiveMan primi, ref Player albert, ref UI UI1, int stage, int round)
        {
            Console.Clear();
            UI1.MakeUI();
            UI1.PrintStage(stage, round);
            UI1.Printstate(albert);
            primi.PrintPrimi2();
            Console.SetCursorPosition(4, 43);
            Console.WriteLine("풀숲을 거닐던중 낯선 원시인들을 만났다.");
            Task.Delay(800).Wait();
            Console.SetCursorPosition(4, 45);
            Console.WriteLine("다행히도 저들은 나에게 궁금함과 호의를 가지고있는것 같았다.");
            Task.Delay(800).Wait();
            Console.SetCursorPosition(4, 47);
            Console.WriteLine("원주민들에게 환대를 받고 체력을 회복했으며 화석을 받았다.");
            Task.Delay(800).Wait();
            Console.SetCursorPosition(4, 49);
            Console.WriteLine("체력이 100회복되고 화석을 30 얻었습니다.");
            albert.hp = albert.hp+100;
            albert.fossils += 30;
            ConsoleKeyInfo input = Console.ReadKey();
        }

        static void MeetDisaster(ref Player albert, ref UI UI1, int stage, int round)
        {
            Console.Clear();
            
            UI1.MakeUI();
            UI1.PrintStage(stage, round);
            UI1.PrintVolcano();
            Console.SetCursorPosition(4, 43);
            Console.WriteLine("갑자기 땅이 흔들리기 시작했다...");
            Task.Delay(600).Wait();
            Console.SetCursorPosition(4, 45);
            Console.WriteLine("화산이 폭발했다!!! 여기저기서 화산재와 파편이 내려오고 있다..");
            Task.Delay(600).Wait();
            Console.SetCursorPosition(4, 47);
            Console.WriteLine("자동차에 몸을맡기고 간신히 탈출에 성공했다....");
            Task.Delay(600).Wait();
            albert.hp = albert.hp - 50;
            Console.SetCursorPosition(4, 49);
            Console.WriteLine("HP가 50 감소하였습니다.....");
            ConsoleKeyInfo input = Console.ReadKey();
        }

       

        static void BattleFirstScript(dinosaur a1)
        {
            Console.SetCursorPosition(4, 43);
            Console.Write("아직까지 {0}는 나를 발견하지 못한것같다 무었을해야할까?",a1.name);
            Console.SetCursorPosition(4, 45);
            Console.Write("1.알을 조용히 가져가보자");
            Console.SetCursorPosition(4, 47);
            Console.Write("2.{0}가 좋아하는 풀을 줘서 경계를 풀어보자", a1.name);
            Console.SetCursorPosition(4, 49);
            Console.Write("3.아이템을 써서 피를 회복하자.");
        }

        static void PrintBattleCursorPosition()
        {
            Console.SetCursorPosition(70, 45);
            Console.Write("▲");
            Console.SetCursorPosition(70, 47);
            Console.Write("▲");
            Console.SetCursorPosition(70, 49);
            Console.Write("▲");
        }

        static void PrintBattleDinosaur(dinosaur array)
        {
            if (array.name == "트리케라톱스")
            {
                array.PrintTri();
            }
            else if (array.name == "브라키오사우루스")
            {
                array.PrintBra();
            }
            else if (array.name == "벨로시랩터")
            {
                array.PrintRapter();
            }
            else if (array.name == "파라사우롤로푸스")
            {
                array.PrintPhy();
            }
            else if (array.name == "스테고사우루스")
            {
                array.PrintStego();
            }
            else if (array.name == "티라노사우루스")
            {
                array.PrintTrano();
            }
            else if (array.name == "알로사우루스")
            {
                array.PrintAlo();
            }
            else if (array.name == "안킬로사우루스")
            {
                array.PrintAnkilo();
            }
            else if (array.name == "프테라노돈")
            {
                array.PrintPtera();
            }
            else if (array.name == "기가노토사우루스")
            {
                array.PrintGiga();
            }
        }

        static void Battle1(dinosaur array, Player albert, ref bool alive, UI UI1,ref int stage, ref int round)
        {
            while (true)
            {
                if (albert.hp <= 0)
                {
                    alive = false;
                    Console.Clear();
                    break;
                }
                else if (array.hp <= 0)
                {
                    UI1.MakeUI();
                    UI1.PrintStage(stage, round);
                    UI1.Printstate(albert);
                    albert.PrintPlayer();
                    UI1.PrintDesert();
                    Console.SetCursorPosition(4, 43);
                    Console.WriteLine("공룡과의 싸움에서 승리하고 화석을 20얻었다.");
                    albert.fossils += 30;
                    Task.Delay(1000).Wait();
                    alive = true;
                    albert.eggCount++;
                    ConsoleKeyInfo input = Console.ReadKey();
                    Console.Clear();
                    break;
                }
                Console.Clear();

                UI1.MakeUI();
                UI1.PrintStage(stage, round);
                UI1.Printstate(albert);
                albert.PrintPlayer();
                UI1.PrintDesert();
                PrintBattleDinosaur(array);
                Console.SetCursorPosition(30, 32);
                Console.WriteLine("{0}", array.name);
                Console.SetCursorPosition(30, 34);
                Console.WriteLine("현재HP  {0}", array.hp);
                Task.Delay(400).Wait();
                Console.SetCursorPosition(80, 32);
                Console.WriteLine("{0}", albert.name);
                Console.SetCursorPosition(80, 34);
                Console.WriteLine("현재HP  {0}", albert.hp);
                Task.Delay(400).Wait();
                Console.SetCursorPosition(4, 43);
                Console.WriteLine("알버트가 {0}를 {1}로 공격했다.", array.name, albert.weaponName);
                Task.Delay(400).Wait();
                Console.SetCursorPosition(4, 45);
                Console.WriteLine("{0}의 HP가 {1}만큼 떨어졌다.", array.name, albert.weaponPower);
                array.hp = array.hp - albert.weaponPower;
                Task.Delay(400).Wait();
                Console.SetCursorPosition(4, 47);
                Console.WriteLine("{0}가 알버트를 공격했다.", array.name);
                Task.Delay(400).Wait();
                Console.SetCursorPosition(4, 49);
                Console.WriteLine("알버트의 HP가 {0}만큼 떨어졌다.", array.power);
                albert.hp = albert.hp - array.power;
                Task.Delay(1000).Wait();
            }
        }

        static void Drawleaf(UI UI1, int stage, int round, Player albert)
        {
            Console.Clear();
            UI1.MakeUI();
            UI1.PrintStage(stage, round);
            UI1.Printstate(albert);
            Console.SetCursorPosition(45, 9);
            Console.WriteLine("               ,                          ");
            Console.SetCursorPosition(45, 10);
            Console.WriteLine("        }`-.   ,          ,               ");
            Console.SetCursorPosition(45, 11);
            Console.WriteLine("        \\ \\ '-' \\      .-'{               ");
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("        _} .  | ,`\\   /  ' ;    .-;\\      ");
            Console.SetCursorPosition(45, 13);
            Console.WriteLine("       {    \\ |    | / `/  '-.,/ ; |      ");
            Console.SetCursorPosition(45, 14);
            Console.WriteLine("       { -- -.  '  '`-, .--._.' ;  \\__    ");
            Console.SetCursorPosition(45, 15);
            Console.WriteLine("        \\     \\ | '  /  |`.    ;    _,`\\  ");
            Console.SetCursorPosition(45, 16);
            Console.WriteLine("         '. '-     ' `_- '.`;  ; ,-`_.-'  ");
            Console.SetCursorPosition(45, 17);
            Console.WriteLine("     ,--.  \\    `   /` '--'  `;.` (`  _   ");
            Console.SetCursorPosition(45, 18);
            Console.WriteLine("  .--.\\  '._) '-. \\ \\ `-.    ;     `-';|  ");
            Console.SetCursorPosition(45, 19);
            Console.WriteLine("  '. -. '         __ '.  ;  ;     _,-' /  ");
            Console.SetCursorPosition(45, 20);
            Console.WriteLine("   { __'.\\  ' '-,/; `-'   ';`.- `   .-'   ");
            Console.SetCursorPosition(45, 21);
            Console.WriteLine("    '-.  `-._'  | `;     ;`'   .-'`       ");
            Console.SetCursorPosition(45, 22);
            Console.WriteLine("      <_ -'   ` .\\  `;  ;     (_.'`\\      ");
            Console.SetCursorPosition(45, 23);
            Console.WriteLine("      _.;-\"``\"'-._'. `:;  ___, _.-' |     ");
            Console.SetCursorPosition(45, 24);
            Console.WriteLine("  .-'\\'. '.` \\ \\_,_`\\ ;##`   `';  _.'     ");
            Console.SetCursorPosition(45, 25);
            Console.WriteLine(" /_'._\\ \\  \\__;#####./###.      \\`        ");
            Console.SetCursorPosition(45, 26);
            Console.WriteLine(" \\.' .'`/\"`/ (#######)###::.. _.'         ");
            Console.SetCursorPosition(45, 27);
            Console.WriteLine("  '.' .'  ; , |:.  `|()##`\"\"\"`            ");
            Console.SetCursorPosition(45, 28);
            Console.WriteLine("    `'-../__/_\\::   /O()()o               ");
            Console.SetCursorPosition(45, 29);
            Console.WriteLine("             ()'._.'`()()'                ");

        }
    }
}
