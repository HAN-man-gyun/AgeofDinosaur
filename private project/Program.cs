using System;
using System.Collections.Generic;
using System.Linq;
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
            //공룡알 갯수 생성
            int EggCount=0;
            //플레이어 생존여부확인변수
            bool live = true;
            //UI객체 생성
            UI UI1 = new UI();
            //플레이어 생성,초기화
            Player albert = new Player();
            albert.IntiailizePlayer("알버트","주먹도끼",40,500,500,10,20);
            
            //공룡 초기화
            List<dinosaur> dinosaurs = new List<dinosaur>();
            dinosaur normal1 = new dinosaur();
            normal1.InitDinosaur("트리케라톱스", 200, 200, 30, 10, "초식공룡", 50);
            dinosaurs.Add(normal1);
            dinosaur normal2 = new dinosaur();
            normal2.InitDinosaur("브라키오사오루스", 200, 200, 40, 5, "초식공룡", 50);
            dinosaurs.Add(normal2);
            dinosaur normal3 = new dinosaur();
            normal3.InitDinosaur("드로마에오사우르스", 300, 300, 30, 10, "초식공룡", 100);
            dinosaurs.Add(normal3);
            dinosaur normal4 = new dinosaur();
            normal4.InitDinosaur("벨로시랩터", 200, 200, 30, 40, "초식공룡", 20);
            dinosaurs.Add(normal4);
            dinosaur boss5 = new dinosaur();
            boss5.InitDinosaur("티라노사우루스", 300, 300, 50, 10, "육식공룡", 0);
            dinosaurs.Add(boss5);
            dinosaur normal6 = new dinosaur();
            normal6.InitDinosaur("스테고사우루스", 200, 200, 30, 30, "초식공룡", 35);
            dinosaurs.Add(normal6);
            dinosaur normal7 = new dinosaur();
            normal7.InitDinosaur("알로사우루스", 300, 300, 40, 10, "육식공룡", 15);
            dinosaurs.Add(normal7);
            dinosaur normal8 = new dinosaur();
            normal8.InitDinosaur("안킬로사우루스", 400, 400, 30, 10, "초식공룡", 35);
            dinosaurs.Add(normal8);
            dinosaur normal9 = new dinosaur();
            normal9.InitDinosaur("프테라노돈", 300, 300, 40, 40, "육식공룡", 50);
            dinosaurs.Add(normal9);
            dinosaur boss10 = new dinosaur();
            boss10.InitDinosaur("기간토노사우루스", 600, 600, 100, 20, "육식공룡", 0);
            dinosaurs.Add(boss10);
            //원주민리스트생성
            List<PrimitiveMan> mans = new List<PrimitiveMan>();
            PrimitiveMan man1 = new PrimitiveMan();
            man1.InitPrimitive();
            mans.Add(man1);
            PrimitiveMan man2 = new PrimitiveMan();
            man2.InitPrimitive();
            mans.Add(man2);
            //shop객체생성
            Shop shop = new Shop();
           


            //랜덤객체 생성
            Random rnd = new Random();
            //랜덤값을 담을 temp변수
            int temp;
            temp = rnd.Next(1,101);
            //공룡인덱스 변수
            int dinoIdx=0;
            //UI출력
            UI1.MakeUI();
            //기본스크립트 출력
            UI1.PrintState();
            while (true)
            {
                
                if (round != 6 && round !=3) //6라운드가 아니라면  //6라운드는 보스 공룡
                {
                    if (temp <= 30)
                    {
                        live=Battle(dinosaurs[dinoIdx],albert, UI1);
                        round++;
                        dinoIdx++;
                        if(live ==false)
                        {
                            Console.WriteLine("게임에서 패배했습니다. 다시 도전해주세요.");
                            break;
                        }

                    }
                    else if (temp > 30 && temp <= 60)
                    {
                        //원주민
                        round++;
                        dinoIdx++;
                    }
                    else if (temp > 60 && temp <= 100)
                    {
                        //화산폭발
                        round++;
                        dinoIdx++;
                    }
                }
                else if (round == 6)
                {
                    //보스공룡과의 전투
                    //battle;();
                    round++;
                    dinoIdx++;
                }
                else if(round ==3)
                {
                    //상점 구현
                    round++;
                    dinoIdx++;
                }
                if (round == 7)
                {
                    stage++;
                    round = 0;
                }

                if (EggCount == 10) 
                {
                    Console.SetCursorPosition(4,43);
                    Console.WriteLine("마침내 타임머신이 모두 수리되었습니다!!");
                    Console.WriteLine("알버트 박사는 타임머신을 타고 현대로 돌아갑니다....");
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
        static bool Battle(dinosaur array, Player albert, UI UI1)
        {
            bool alive = true;
            Console.Clear();
            UI1.MakeUI();
            Console.SetCursorPosition(4,41);
            Console.WriteLine("풀숲에서 갑자기 {0} {1}가 나타났다!!!", array.type ,array.name);
            Task.Delay(1000).Wait();
            while (true)
            {
                Console.Clear();
                UI1.MakeUI();
                if (albert.hp <= 0)
                {
                    alive = false;
                    return alive;
                }
                else if (array.hp<= 0)
                {
                    alive = true;
                    return alive;
                }
                Console.SetCursorPosition(4, 20);
                Console.WriteLine("{0}", array.name);
                Console.SetCursorPosition(4, 21);
                Console.WriteLine("현재HP{0}", array.hp);
                Task.Delay(400).Wait();
                Console.SetCursorPosition(30, 20);
                Console.WriteLine("{0}", albert.name);
                Console.SetCursorPosition(30, 21);
                Console.WriteLine("현재HP{0}", albert.hp);
                Task.Delay(400).Wait();
                Console.SetCursorPosition(4, 41);
                Console.WriteLine("알버트가 {0}를 {1}로 공격했다.", array.name, albert.weaponName);
                Task.Delay(400).Wait();
                Console.SetCursorPosition(4, 42);
                Console.WriteLine("{0}의 HP가 {1}만큼 떨어졌다.", array.name, albert.weaponPower);
                array.hp = array.hp - albert.weaponPower;
                Task.Delay(400).Wait();
                Console.SetCursorPosition(4, 43);
                Console.WriteLine("{0}가 알버트를 공격했다.", array.name);
                Task.Delay(400).Wait();
                Console.SetCursorPosition(4, 44);
                Console.WriteLine("알버트의 HP가 {0}만큼 떨어졌다.", array.power);
                albert.hp = albert.hp - array.power;
                Task.Delay(400).Wait();
            }
        }
    }
}
