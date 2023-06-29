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
            Console.SetWindowSize(125, 55);
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

        public void Synopsis ()
        {
            Console.SetCursorPosition(5, 1);
            Console.Write("2200년 천재과학자 알버트는 타임머신 개발에 성공했다.");
            Console.SetCursorPosition(5, 3);
            Console.Write("알버트은 현대에 모든 공룡을 복원하기위해 백악기로 넘어가 공룡알을 가져오기로했다.");
            Console.SetCursorPosition(5, 5);
            Console.Write("타임머신에 몸을 맡겨 시공의폭풍속을 넘어가던 중 타임머신이 흔들리기 시작했다. ");
            Console.SetCursorPosition(5, 7);
            Console.Write("시공간 폭풍을 만난것이다.폭풍을 뚫고 백악기로 도착했지만 엔진이 고장나 제대로 된 착륙을 할수없었다.");
            Console.SetCursorPosition(5, 9); 
            Console.Write("결국 타임머신은 부서지고 부품들이 여기저기로 흩어져버렸다.");
            Console.SetCursorPosition(5, 11);
            Console.Write("무시무시한 공룡들이 사는 세상에서 알버트는 모든 공룡알과 부품을 수집해서 현실로 돌아갈수있을까?");

            Console.SetCursorPosition(10, 20);
            Console.Write("        _____         ");
            Console.SetCursorPosition(10, 21);
            Console.Write("     _.'_____`._      ");
            Console.SetCursorPosition(10, 22);
            Console.Write("   .'.-'  12 `-.`.    ");
            Console.SetCursorPosition(10, 23);
            Console.Write("  /,' 11      1 `.\\   ");
            Console.SetCursorPosition(10, 24);
            Console.Write(" // 10      /   2 \\  ");
            Console.SetCursorPosition(10, 25);
            Console.Write(";;         /       :: ");
            Console.SetCursorPosition(10, 26);
            Console.Write("|| 9  ----O      3 || ");
            Console.SetCursorPosition(10, 27);
            Console.Write("::                 ;; ");
            Console.SetCursorPosition(10, 28);
            Console.Write(" \\ 8           4 //  ");
            Console.SetCursorPosition(10, 29);
            Console.Write("  \\`. 7       5 ,'/   ");
            Console.SetCursorPosition(10, 30);
            Console.Write("   '.`-.__6__.-'.'    ");
            Console.SetCursorPosition(10, 31);
            Console.Write("    ((-._____.-))     ");
            Console.SetCursorPosition(10, 32);
            Console.Write("    _))       ((_     ");
            Console.SetCursorPosition(10, 33);
            Console.Write("   '--'       '--'    ");
            Console.SetCursorPosition(45, 13);
            Console.WriteLine("          /  (  (  (  (  (  (  (  (  (  (  (  (\\_                         ");
            Console.SetCursorPosition(45, 14);
            Console.WriteLine("       _/ `. `. `. `. `. `. `. `. `. `. `. `. `.\\_                        ");
            Console.SetCursorPosition(45, 15);
            Console.WriteLine("      /  )  )  )  )  )  )  )  )  )  )  )  )  )  ) \\_                      ");
            Console.SetCursorPosition(45, 16);
            Console.WriteLine("     / .' .' .' .' .' .' .' .' .' .' .' .' .' .' .' \\_                    ");
            Console.SetCursorPosition(45, 17);
            Console.WriteLine("    | (  (  (  (  (  (  (  (  (  (  (  (  (  (  (  (  \\_                  ");
            Console.SetCursorPosition(45, 18);
            Console.WriteLine("    |. `. `. `. `. `. `. `__`__`__`__`. `. `. `. `. `. `\\_                ");
            Console.SetCursorPosition(45, 19);
            Console.WriteLine("     \\)  )  )  )  )__)__)/           \\_)__)  )  )  )  )  )\\_              ");
            Console.SetCursorPosition(45, 20);
            Console.WriteLine("      |.' .' .' .'/                       \\.' .' .' .' .' .'\\_            ");
            Console.SetCursorPosition(45, 21);
            Console.WriteLine("      |  (  (  ( /                         \\ (  (  (  (  (  ( \\           ");
            Console.SetCursorPosition(45, 22);
            Console.WriteLine("      |`. `. `. |                           \\ `. `. `. `. `. `.\\          ");
            Console.SetCursorPosition(45, 23);
            Console.WriteLine("      |  )  )  )|                            \\  )  )  )  )  )  )|         ");
            Console.SetCursorPosition(45, 24);
            Console.WriteLine("      |.' .' .' |                             \' .' .' .' .' .' |         ");
            Console.SetCursorPosition(45, 25);
            Console.WriteLine("      |  (  (  (|  ______         _____        |(  (  (  (  (  (|         ");
            Console.SetCursorPosition(45, 26);
            Console.WriteLine("      |`. `. `. | /______)       (_____\\       | `. `. `. `. `. |         ");
            Console.SetCursorPosition(45, 27);
            Console.WriteLine("      |  )  )  )|//                    \\_      \\  )  )  )  )  /          ");
            Console.SetCursorPosition(45, 28);
            Console.WriteLine("       \' .' .' |  _____          _____          |'__' .' .' ./           ");
            Console.SetCursorPosition(45, 29);
            Console.WriteLine("        |(  (  (| ( [O] )        ( [O] )         |/  \\(  (  ((            ");
            Console.SetCursorPosition(45, 30);
            Console.WriteLine("        | `. `. |  \\___/          \\___/             \\ |`. `. `\\           ");
            Console.SetCursorPosition(45, 31);
            Console.WriteLine("         \\_ )  )|          ,                        / |  )  )  \\          ");
            Console.SetCursorPosition(45, 32);
            Console.WriteLine("           \\ .' .\\        |   .                      / .' .' .' \\         ");
            Console.SetCursorPosition(45, 33);
            Console.WriteLine("            \\_ (  |      (     )                 |\\_/ (  (  (  ( )        ");
            Console.SetCursorPosition(45, 34);
            Console.WriteLine("              \\ `.|       \\___/                  |. `. `. `. `__/         ");
            Console.SetCursorPosition(45, 35);
            Console.WriteLine("               \\__|                              | )  )  ) __/            ");
            Console.SetCursorPosition(45, 36);
            Console.WriteLine("                  |      _______                 |' .' .__/               ");
            Console.SetCursorPosition(45, 37);
            Console.WriteLine("                  |    _/////\\\\____          _/.\\____/_____             ");
            Console.SetCursorPosition(45, 38);
            Console.WriteLine("                  |   ///////\\\\\\\\\\        / |.|\\,%\\,%\\,%\\_______     ");
            Console.SetCursorPosition(45, 39);
            Console.WriteLine("                   \\ |///////\\\\\\\\\\|     _/  |.|\\%,\\%,\\%,\\%,\\%,\\%,\\____");
            Console.SetCursorPosition(45, 40);
            Console.WriteLine("                    \\   \\__________/       /   /. |%\\,%\\,%\\,%\\,%\\,%\\,%\\,%\\");
            Console.SetCursorPosition(45, 41);
            Console.WriteLine("                   __\\                    /   /. /%,\\%,\\%,\\%,\\%,\\%,\\%,\\%,\\");
            Console.SetCursorPosition(45, 42);
            Console.WriteLine("                 _/%\\,\\_               __/   /. /%\\,%\\,%\\,%\\,%\\,%\\,%\\,%\\,%");
            Console.SetCursorPosition(45, 43);
            Console.WriteLine("       _________/%\\,%\\,%\\_         ___/    _/. /\\,%\\,%\\,%\\,%\\,%\\,%\\,%\\,%\\,");
            Console.SetCursorPosition(45, 44);
            Console.WriteLine("     _/%,\\%,\\%,\\%,\\%,\\%/XX\\_______/      _/. ./,\\%,\\%,\\%,\\%,\\%,\\%,\\%,\\%,\\%");
            Console.SetCursorPosition(45, 45);
            Console.WriteLine("  __/,%\\,%\\,%\\,%\\,%\\,%/XXXXX\\_        __/. ./%\\,%\\,%\\,%\\,%\\,%\\,%\\,%\\,%\\,%\\");
            Console.SetCursorPosition(45, 46);
            Console.WriteLine(" /%,\\%,\\%,\\%,\\%,\\%,\\%/XXXXXXXX\\      /. . ./%,\\%,\\%,\\%,\\%,\\%,\\%,\\%,\\%,\\%,\\");
            

                        ConsoleKeyInfo input1 = Console.ReadKey();
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

            Console.SetCursorPosition(98, 44);
            Console.WriteLine("        -''--.        ");
            Console.SetCursorPosition(98, 45);
            Console.WriteLine("     _`>   `\\.-'<     ");
            Console.SetCursorPosition(98, 46);
            Console.WriteLine("  _.'     _     '._   ");
            Console.SetCursorPosition(98, 47);
            Console.WriteLine(".'   _.='   '=._   '. ");
            Console.SetCursorPosition(98, 48);
            Console.WriteLine(">_   / /_\\ /_\\ \\   _< ");
            Console.SetCursorPosition(98, 49);
            Console.WriteLine("  / (  \\o/\\o/  ) \\   ");
            Console.SetCursorPosition(98, 50);
            Console.WriteLine("  >._\\ .-,_)-. /_.<   ");
            Console.SetCursorPosition(98, 51);
            Console.WriteLine("      /__/ \\__\\       ");
            Console.SetCursorPosition(98, 52);
            Console.WriteLine("        '---'         ");

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
            Console.SetCursorPosition(45, 33);
            Console.WriteLine(" Press The Key To Start!");

            Console.SetCursorPosition(10,19);
            Console.WriteLine("             $#########  ");
            Console.SetCursorPosition(10, 20);
            Console.WriteLine("            *#;;########,");
            Console.SetCursorPosition(10, 21);
            Console.WriteLine("            *#==########,");
            Console.SetCursorPosition(10, 22);
            Console.WriteLine("            *###########,");
            Console.SetCursorPosition(10, 23);
            Console.WriteLine("            *#####=*****,");
            Console.SetCursorPosition(10, 24);
            Console.WriteLine("            *#####=**;   ");
            Console.SetCursorPosition(10, 25);
            Console.WriteLine("           ,=####****;   ");
            Console.SetCursorPosition(10, 26);
            Console.WriteLine("*,     ,,########,,      ");
            Console.SetCursorPosition(10, 27);
            Console.WriteLine("*#=;  ;##########,=      ");
            Console.SetCursorPosition(10, 28);
            Console.WriteLine("*##=,,=########## ;      ");
            Console.SetCursorPosition(10, 29);
            Console.WriteLine("*################        ");
            Console.SetCursorPosition(10, 30);
            Console.WriteLine("  ;=##########;~         ");
            Console.SetCursorPosition(10, 31);
            Console.WriteLine("    ,#######$-.          ");
            Console.SetCursorPosition(10, 32);
            Console.WriteLine("     *$##$*$=.           ");
            Console.SetCursorPosition(10, 33);
            Console.WriteLine("      *#:, ,*.           ");
            Console.SetCursorPosition(10, 34);
            Console.WriteLine("      * *,   **,         ");
            Console.SetCursorPosition(10, 35);
            Console.WriteLine("      ; *,   ; *,        ");

           
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

        public void PrintVolcano()
        {
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("               (   (( . : (    .)   ) :  )                 ");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("                 (   ( :  .  :    :  )  ))                 ");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("                  ( ( ( (  .  :  . . ) )                   ");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("                   ( ( : :  :  )   )  )                    ");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("                    ( :(   .   .  ) .'                     ");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("                     '. :(   :    )                        ");
            Console.SetCursorPosition(3, 11);
            Console.WriteLine("                       (   :  . )  )                       ");
            Console.SetCursorPosition(3, 12);
            Console.WriteLine("                        ')   :   #@                        ");
            Console.SetCursorPosition(3, 13);
            Console.WriteLine("                       #',### \" #@                         ");
            Console.SetCursorPosition(3, 14);
            Console.WriteLine("                      #/ @'#~@#~/\\                         ");
            Console.SetCursorPosition(3, 15);
            Console.WriteLine("                    ##  @@# @##@  `..@,                    ");
            Console.SetCursorPosition(3, 16);
            Console.WriteLine("                  @#/  #@#   _##     `\\                    ");
            Console.SetCursorPosition(3, 17);
            Console.WriteLine("                @##;  `#~._.' ##@      \\_                  ");
            Console.SetCursorPosition(3, 18);
            Console.WriteLine("              .-#/           @#@#@--,_,--\\                 ");
            Console.SetCursorPosition(3, 19);
            Console.WriteLine("             / `@#@..,     .~###'         `~.              ");
            Console.SetCursorPosition(3, 20);
            Console.WriteLine("           _/         `-.-' #@####@          \\             ");
            Console.SetCursorPosition(3, 21);
            Console.WriteLine("        __/     &^^       ^#^##~##&&&   %     \\_           ");
            Console.SetCursorPosition(3, 22);
            Console.WriteLine("       /       && ^^      @#^##@#%%#@&&&&  ^    \\          ");
            Console.SetCursorPosition(3, 23);
            Console.WriteLine("     ~/         &&&    ^^^   ^^   &&&  %%% ^^^   `~._      ");
            Console.SetCursorPosition(3, 24);
            Console.WriteLine("  .-'   ^^    %%%. &&   ___^     &&   && &&   ^^     \\     ");
            Console.SetCursorPosition(3, 25);
            Console.WriteLine(" /    ^^^ ___&&& X & && |n|   ^ ___ %____&& . ^^^^^   `~.  ");
            Console.SetCursorPosition(3, 26);
            Console.WriteLine("          |M|       ---- .  ___.|n| /\\___\\  X              ");
            Console.SetCursorPosition(3, 27);
            Console.WriteLine("                    |mm| X  |n|X    ||___|                 ");

            Console.SetCursorPosition(55, 8);
            Console.WriteLine("       /|                                                 ");
            Console.SetCursorPosition(55, 9);
            Console.WriteLine("      / |                                                 ");
            Console.SetCursorPosition(55, 10);
            Console.WriteLine("     /  /                                                 ");
            Console.SetCursorPosition(55, 11);
            Console.WriteLine("    |   |                                                 ");
            Console.SetCursorPosition(55, 12);
            Console.WriteLine("   /    |                                                 ");
            Console.SetCursorPosition(55, 13);
            Console.WriteLine("   |    \\_                                                ");
            Console.SetCursorPosition(55, 14);
            Console.WriteLine("   |      \\__                                             ");
            Console.SetCursorPosition(55, 15);
            Console.WriteLine("   \\       __\\_______                                     ");
            Console.SetCursorPosition(55, 16);
            Console.WriteLine("    \\                 \\_                                  ");
            Console.SetCursorPosition(55, 17);
            Console.WriteLine("    | /                 \\                                 ");
            Console.SetCursorPosition(55, 18);
            Console.WriteLine("    \\/                  \\                                ");
            Console.SetCursorPosition(55, 19);
            Console.WriteLine("     |                    |                               ");
            Console.SetCursorPosition(55, 20);
            Console.WriteLine("     \\                   \\|                               ");
            Console.SetCursorPosition(55, 21);
            Console.WriteLine("     |                    \\                               ");
            Console.SetCursorPosition(55, 22);
            Console.WriteLine("     \\                     |                              ");
            Console.SetCursorPosition(55, 23);
            Console.WriteLine("     /\\    \\_               \\                             ");
            Console.SetCursorPosition(55, 24);
            Console.WriteLine("    / |      \\__ (   )       \\                            ");
            Console.SetCursorPosition(55, 25);
            Console.WriteLine("   /  \\      / |\\  /       __\\____                       ");
            Console.SetCursorPosition(55, 26);
            Console.WriteLine("   |  ,     |  /\\ \\ \\__    |       \\_                     ");
            Console.SetCursorPosition(55, 27);
            Console.WriteLine("   \\_/|\\___/   \\   \\}}}\\__|  (@)     )                    ");
            Console.SetCursorPosition(55, 28);
            Console.WriteLine("    \\)\\)\\)      \\_\\---\\   \\|       \\ \\                    ");
            Console.SetCursorPosition(55, 29);
            Console.WriteLine("                  \\>\\>\\>   \\   /\\__o_o)                   ");
            Console.SetCursorPosition(55, 30);
            Console.WriteLine("                            | /  VVVVV                    ");
            Console.SetCursorPosition(55, 31);
            Console.WriteLine("                            \\ \\    \\           _____ /     ");
            Console.SetCursorPosition(55, 32);
            Console.WriteLine("                             \\ \\MMMMM          |  O O|      ");
            Console.SetCursorPosition(55, 33);
            Console.WriteLine("                              \\______/         /___|_|/\\_   ");
            Console.SetCursorPosition(55, 34);
            Console.WriteLine("                                           ==( |          |   ");
            Console.SetCursorPosition(55, 35);
            Console.WriteLine("                                              (o)====(o)*/    ");
        }

        public void PrintDesert()
        {
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("  ........::::::::::::..           .......|...............::::::::........    ");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("     .:::::;;;;;;;;;;;:::::.... .     \\   | ../....::::;;;;:::::.......       ");
            Console.SetCursorPosition(20, 7);
            Console.WriteLine("         .       ...........   / \\_   \\  |  /     ......  .     ........./\\  ");
            Console.SetCursorPosition(20, 8);
            Console.WriteLine("...:::../\\_  ......     ..._/'   \\\\_  \\###/   /\\_    .../ \\_.......   _//   ");
            Console.SetCursorPosition(20, 9);
            Console.WriteLine(".::::./   \\\\ _   .../\\    /'      \\\\#######//   \\/\\   //   \\_   ....////   ");
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("    _/      \\\\   _/ \\\\ /  x       \\\\###////      \\////     \\__  _/////   ");
            Console.SetCursorPosition(20, 11);
            Console.WriteLine("  ./   x       \\\\/     \\/ x X           \\//////                   \\/////     ");
            Console.SetCursorPosition(20, 12);
            Console.WriteLine(" /     XxX     \\/         XxX X                                    ////   x  ");
            Console.SetCursorPosition(20, 13);
            Console.WriteLine("-----XxX-------------|-------XxX-----------*--------|---*-----|------------X--");
            Console.SetCursorPosition(20, 14);
            Console.WriteLine("       X        _X      *    X      **         **             x   **    *  X  ");
            Console.SetCursorPosition(20, 15);
            Console.WriteLine("      _X                    _X           x                *          x     X_ ");
        }
    }
}
