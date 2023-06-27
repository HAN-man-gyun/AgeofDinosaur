using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace private_project
{
    public class UI
    {
        //Ui 출력함수
        public void MakeUI()
        {
            Console.SetWindowSize(125, 60);
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┏───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┓");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┗───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┛");
            Console.SetCursorPosition(0, 40);
            Console.WriteLine("┏───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┓");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┃                                                                                                                       ┃");
            Console.WriteLine("┗───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┛");
        }

        //이벤트 발생전  출력함수
        public void PrintRoundStart()
        {
            Console.Clear();
            MakeUI();
            Console.SetCursorPosition(4, 43);
            Console.Write("알버트박사는 알을 찾아서 모험을 떠납니다....");

        }

        public void Printstate(Player albert)
        {
            Console.SetCursorPosition(80, 42);
            Console.Write("박사알버트");
            Console.SetCursorPosition(80, 44);
            Console.Write("최대체력:{0}", albert.maxHp);
            Console.SetCursorPosition(80, 46);
            Console.Write("현재체력:{0}", albert.hp);
            Console.SetCursorPosition(80, 48);
            Console.Write("회피율:{0}", albert.luck);
            Console.SetCursorPosition(80, 50);
            Console.Write("현재무기:{0}", albert.weaponName);
            Console.SetCursorPosition(80, 52);
            Console.Write("무기공력력:{0}", albert.weaponPower);
            Console.SetCursorPosition(80, 54);
            Console.Write("현재화석:{0}", albert.fossils);

            Console.SetCursorPosition(100, 42);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@");
            Console.SetCursorPosition(100, 43);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@");
            Console.SetCursorPosition(100, 44); 
            Console.WriteLine("@@@@@@@@@#@@@@@@@@@@");
            Console.SetCursorPosition(100, 45); 
            Console.WriteLine("@@@@@@@#,..@@@@@@@@@");
            Console.SetCursorPosition(100, 46); 
            Console.WriteLine("@@@@@@@=;!*$@@@@@@@@");
            Console.SetCursorPosition(100, 47); 
            Console.WriteLine("@@@@@@@;!,=$@@@@@@@@");
            Console.SetCursorPosition(100, 48); 
            Console.WriteLine("@@@@@@@#:~*@###@@@@@");
            Console.SetCursorPosition(100, 49); 
            Console.WriteLine("@@@@@$ ;: ;:: ;@@@@@");
            Console.SetCursorPosition(100, 50); 
            Console.WriteLine("@@@@   :!..,-:!#@@@@");
            Console.SetCursorPosition(100, 51); 
            Console.WriteLine("@@@#...~,-~.....@@@@");
            Console.SetCursorPosition(100, 52); 
            Console.WriteLine("@@@@@###########@@@@");
            Console.SetCursorPosition(100, 53); 
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@");
            Console.SetCursorPosition(100, 54); 
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@");

        }
        public void PrintStage(int stage, int round)
        {
            Console.SetCursorPosition(50, 3);
            Console.Write("stage {0}  :  {1}", stage, round);
        }



        public void PrintStartScreen()
        {
            Console.SetCursorPosition(22, 4);
            Console.WriteLine("d888888b db   db d88888b       .d8b.   d888b  d88888b       .d88b.  d88888b ");
            Console.SetCursorPosition(22, 5);
            Console.WriteLine("`~~88~~' 88   88 88'          d8' `8b 88' Y8b 88'          .8P  Y8. 88'     ");
            Console.SetCursorPosition(22, 6);
            Console.WriteLine("   88    88ooo88 88ooooo      88ooo88 88      88ooooo      88    88 88ooo   ");
            Console.SetCursorPosition(22, 7);
            Console.WriteLine("   88    88~~~88 88~~~~~      88~~~88 88  ooo 88~~~~~      88    88 88~~~   ");
            Console.SetCursorPosition(22, 8);
            Console.WriteLine("   88    88   88 88.          88   88 88. ~8~ 88.          `8b  d8' 88      ");
            Console.SetCursorPosition(22, 9);
            Console.WriteLine("   YP    YP   YP Y88888P      YP   YP  Y888P  Y88888P       `Y88P'  YP      ");
            Console.SetCursorPosition(22, 10);
            Console.WriteLine("                                                                            ");
            Console.SetCursorPosition(22, 11);
            Console.WriteLine("                                                                            ");
            Console.SetCursorPosition(22, 12);
            Console.WriteLine("     d8888b. d888888b d8b   db  .d88b.  .d8888.  .d8b.  db    db d8888b.    ");
            Console.SetCursorPosition(22, 13);
            Console.WriteLine("     88  `8D   `88'   888o  88 .8P  Y8. 88'  YP d8' `8b 88    88 88  `8D    ");
            Console.SetCursorPosition(22, 14);
            Console.WriteLine("     88   88    88    88V8o 88 88    88 `8bo.   88ooo88 88    88 88oobY'    ");
            Console.SetCursorPosition(22, 15);
            Console.WriteLine("     88   88    88    88 V8o88 88    88   `Y8b. 88~~~88 88    88 88`8b      ");
            Console.SetCursorPosition(22, 16);
            Console.WriteLine("     88  .8D   .88.   88  V888 `8b  d8' db   8D 88   88 88b  d88 88 `88.    ");
            Console.SetCursorPosition(22, 17);
            Console.WriteLine("     Y8888D' Y888888P VP   V8P  `Y88P'  `8888Y' YP   YP ~Y8888P' 88   YD    ");

            Console.SetCursorPosition(45, 31);
            Console.WriteLine(" Press The Key To Start!");
        }


        public void PrintEnding()
        {
            Console.SetCursorPosition(34, 4);
            Console.WriteLine("######## ##     ## ########    ######## ##    ## ########  ");
            Console.SetCursorPosition(34, 5); 
            Console.WriteLine("   ##    ##     ## ##          ##       ###   ## ##     ## ");
            Console.SetCursorPosition(34, 6); 
            Console.WriteLine("   ##    ##     ## ##          ##       ####  ## ##     ## ");
            Console.SetCursorPosition(34, 7); 
            Console.WriteLine("   ##    ######### ######      ######   ## ## ## ##     ## ");
            Console.SetCursorPosition(34, 8); 
            Console.WriteLine("   ##    ##     ## ##          ##       ##  #### ##     ## ");
            Console.SetCursorPosition(34, 9); 
            Console.WriteLine("   ##    ##     ## ##          ##       ##   ### ##     ## ");
            Console.SetCursorPosition(34, 10); 
            Console.WriteLine("   ##    ##     ## ########    ######## ##    ## ########  ");




            Console.SetCursorPosition(33, 13);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$;;;;;!!!;#");
            Console.SetCursorPosition(33, 14);
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*!!!.          .@");
            Console.SetCursorPosition(33, 15); 
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*!      !!~      .,,@");
            Console.SetCursorPosition(33, 16); 
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@$*            .*:, .,,.$@");
            Console.SetCursorPosition(33, 17); 
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*         .        ~*~,.!@@");
            Console.SetCursorPosition(33, 18); 
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#;       .,    ...       *=@@@");
            Console.SetCursorPosition(33, 19); 
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@$$$$##~        ,        ,     ..#@@@@");
            Console.SetCursorPosition(33, 20); 
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@#$     :;          ,.     ...  ..,-@@@@@@");
            Console.SetCursorPosition(33, 21); 
            Console.WriteLine("@@@@@@@@@@@@@@@@@#,.-#@@@#.             .,,,.  ..,,,@@@@@@@@");
            Console.SetCursorPosition(33, 22); 
            Console.WriteLine("@@@@@@@@@@@@@@@=,#@@@@@@@-.     .:$#.      ...,,,;@@@@@@@@@@");
            Console.SetCursorPosition(33, 23); 
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@~,-**..,#:$,,,  . .,,,,-@@@@@@@@@@@@@");
            Console.SetCursorPosition(33, 24); 
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@$---@~@.,,,,,,,,,,.*@@@@@@@@@@@@@@@@");
            Console.SetCursorPosition(33, 25); 
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@$,..  $@#:~~;$,,,,,.==-#@@@@@@@@@@@@@@@@@");
            Console.SetCursorPosition(33, 26); 
            Console.WriteLine("@@@@@@@@@@@@@@@@$,,.. .=*!,,:=:::;$##@;  .#@@@@@@@@@@@@@@@@@");
            Console.SetCursorPosition(33, 27); 
            Console.WriteLine("@@@@@@@@@@@@@@!,....$-#,....#@@@@@@@@#  ~@@@@@@@@@@@@@@@@@@@");
            Console.SetCursorPosition(33, 28); 
            Console.WriteLine("@@@@@@@@@@@@=,.......,....*@@@@@@@@@- *#@@@@@@@@@@@@@@@@@@@@");
            Console.SetCursorPosition(33, 29); 
            Console.WriteLine("@@@@@@@@@@!-......... ..=@@@@@@@@@-*$@@@@@@@@@@@@@@@@@@@@@@@");
            Console.SetCursorPosition(33, 30); 
            Console.WriteLine("@@@@@@@@:,.....,.....=$@@@@@@@@@@#@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.SetCursorPosition(33, 31); 
            Console.WriteLine("@@@@$:-*=:..-*~..-=#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.SetCursorPosition(33, 32); 
            Console.WriteLine("@@==#@@:.-*@!,~*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.SetCursorPosition(33, 33); 
            Console.WriteLine("@@@@$:!*@@=~!@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.SetCursorPosition(33, 34); 
            Console.WriteLine("@#$*#@@@@@$@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");


            Console.SetCursorPosition(42, 45);
            Console.WriteLine("마침내 타임머신이 모두 수리되었습니다!!");
            Console.SetCursorPosition(37, 50);
            Console.WriteLine("알버트 박사는 타임머신을 타고 현대로 돌아갑니다....");
        }


        public void PrintRapter()
        {
            Console.WriteLine("        _             __......___                            ");
            Console.WriteLine("    _-~~ɒ=._       _-~           '-._                        ");
            Console.WriteLine("  >===___ ) ~-.__.-   _       .--.   ~----------_-.-.-=====--");
            Console.WriteLine("          ~-._       ( { \\\\    )  __...--'''               ");
            Console.WriteLine("              ~-=-~~~~//~~~-\\  _~ _=                        ");
            Console.WriteLine("                      \\   \\ _~-=-|                         ");
            Console.WriteLine("                     }~   ( .=   /_|                         ");
            Console.WriteLine("                          ||      }|                         ");
            Console.WriteLine("                          ||       //                        ");
            Console.WriteLine("                          {{        //_                      ");
            Console.WriteLine("                   =    _\\          '~'='                   ");
            Console.WriteLine("                       '~~                                   ");
        }
    }
}
