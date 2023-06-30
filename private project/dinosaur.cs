using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_project
{
    public class dinosaur 
    {
        public string name;
        public int maxHp;
        public int hp;
        public int power;
        public int luck;
        public string type;
        public int friendship;
        public void InitDinosaur(string name, int maxHp, int hp, int power, int luck, string type, int friendship)
        {
            this.name = name;
            this.maxHp = maxHp;
            this.hp = hp;
            this.power = power;
            this.luck = luck;
            this.type = type;
            this.friendship = friendship;
        }

     
        public void PrintTri()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(3, 16);
            Console.WriteLine("                      . - ~ ~ ~ - ._                       ");
            Console.SetCursorPosition(3, 17);
            Console.WriteLine("                   .-~               ~-.    .__       ..   ");
            Console.SetCursorPosition(3, 18);
            Console.WriteLine("                 .`                     ~.}`   /     \\))   ");
            Console.SetCursorPosition(3, 19);
            Console.WriteLine("                \\   \\     /               }     {   \\\\    ");
            Console.SetCursorPosition(3, 20);
            Console.WriteLine("               \\   }       |              }      ^~~\\   \\)");
            Console.SetCursorPosition(3, 21);
            Console.WriteLine("              \\    (       |         .-ˎ  }      ~@- ~-.`\\ ");
            Console.SetCursorPosition(3, 22);
            Console.WriteLine("            .`      / /    |        :    )   }_ (     ___) ");
            Console.SetCursorPosition(3, 23);
            Console.WriteLine("          .`      _ -/ /   \\       _| \\ \\_     .~-_.----`  ");
            Console.SetCursorPosition(3, 24);
            Console.WriteLine("     _ -~     .-~     / +  )~~~--~~ |\\ \\  ~~----~~         ");
            Console.SetCursorPosition(3, 25);
            Console.WriteLine("._-_~_ _ . -~          \\  \\         /  /                   ");
            Console.SetCursorPosition(3, 26);
            Console.WriteLine("                      (  \\_          /  /__                ");
            Console.SetCursorPosition(3, 27);
            Console.WriteLine("                       /___<.         '.___<.              ");
            Console.ResetColor();
        }
        public void PrintBra()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.SetCursorPosition(6, 10);
            Console.WriteLine("                                                     _   ");
            Console.SetCursorPosition(6, 11);
            Console.WriteLine("                                                   ˎ`p~. ");
            Console.SetCursorPosition(6, 12);
            Console.WriteLine("                                                  \\  ˎ__{");
            Console.SetCursorPosition(6, 13);
            Console.WriteLine("                                                 \\ '\\    ");
            Console.SetCursorPosition(6, 14);
            Console.WriteLine("                                                \\  \\     ");
            Console.SetCursorPosition(6, 15);
            Console.WriteLine("                                               \\  \\      ");
            Console.SetCursorPosition(6, 16);
            Console.WriteLine("                           __.__            _.`  \\       ");
            Console.SetCursorPosition(6, 17);
            Console.WriteLine("                    _..--~~     ~~==._  _.-~    \\        ");
            Console.SetCursorPosition(6, 18);
            Console.WriteLine("                 .-~                  '        \\         ");
            Console.SetCursorPosition(6, 19);
            Console.WriteLine("               .`                _-   -_      \\          ");
            Console.SetCursorPosition(6, 20);
            Console.WriteLine("              \\  .    -.        }       /    \\           ");
            Console.SetCursorPosition(6, 21);
            Console.WriteLine("             \\  ;       )      }  /      | .`            ");
            Console.SetCursorPosition(6, 22);
            Console.WriteLine("           \\'   :       )       /  /     |`              ");
            Console.SetCursorPosition(6, 23);
            Console.WriteLine("         \\       /      |        /  |    \\               ");
            Console.SetCursorPosition(6, 24);
            Console.WriteLine("       \\      .-^|     \\.______.-`/     |                ");
            Console.SetCursorPosition(6, 25);
            Console.WriteLine("    _\\      .`   |     )           /|   |                ");
            Console.SetCursorPosition(6, 26);
            Console.WriteLine("..-`    _.'      \\   \\~            ||   |                ");
            Console.SetCursorPosition(6, 27);
            Console.WriteLine("______.-~=      \\   \\_             /|   |                ");
            Console.SetCursorPosition(6, 28);
            Console.WriteLine("               }______o.            /___'o.              ");
            Console.ResetColor();
        }

        public void PrintRapter()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(6, 17);
            Console.WriteLine("                            ___......__             _        ");
            Console.SetCursorPosition(6, 18);
            Console.WriteLine("                        _.-'           ~-_       _.=a~~-_    ");
            Console.SetCursorPosition(6, 19);
            Console.WriteLine("--=====-.-.-_----------~   .--.       _   -.__.-~ ( ___===>  ");
            Console.SetCursorPosition(6, 20);
            Console.WriteLine("              '''--...__  (    \\_\\ { )       _.-~          ");
            Console.SetCursorPosition(6, 21);
            Console.WriteLine("                        =_ ~_  \\-~~~//~~~~-=-~              ");
            Console.SetCursorPosition(6, 22);
            Console.WriteLine("                         |-=-~_ \\   \\                      ");
            Console.SetCursorPosition(6, 23);
            Console.WriteLine("                         |_/   =. )   ~}                     ");
            Console.SetCursorPosition(6, 24);
            Console.WriteLine("                         |}      ||                          ");
            Console.SetCursorPosition(6, 25);
            Console.WriteLine("                        //       ||                          ");
            Console.SetCursorPosition(6, 26);
            Console.WriteLine("                      _//        {{                          ");
            Console.SetCursorPosition(6, 27);
            Console.WriteLine("                   '='~'          \\_    =                   ");
            Console.SetCursorPosition(6, 28);
            Console.WriteLine("                                   ~~'                       ");
            Console.ResetColor();
        }

        public void PrintPhy()
        {   
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(6, 12);
            Console.WriteLine("                                             _          ");
            Console.SetCursorPosition(6, 13);
            Console.WriteLine("                                             //         ");
            Console.SetCursorPosition(6, 14);
            Console.WriteLine("                                              //        ");
            Console.SetCursorPosition(6, 15);
            Console.WriteLine("                                               )/__     ");
            Console.SetCursorPosition(6, 16);
            Console.WriteLine("                                             .-~  ɒ-~._ ");
            Console.SetCursorPosition(6, 17);
            Console.WriteLine("                     _.=~~~~=.._           .`    (_____{");
            Console.SetCursorPosition(6, 18);
            Console.WriteLine("                  .='           ~=._      \\    _-~      ");
            Console.SetCursorPosition(6, 19);
            Console.WriteLine("              _.=:   .=.            ~=._.`    \\         ");
            Console.SetCursorPosition(6, 20);
            Console.WriteLine("             (\\ :   \\   )         __         -          ");
            Console.SetCursorPosition(6, 21);
            Console.WriteLine("             : :   |     )       }  )      .~           ");
            Console.SetCursorPosition(6, 22);
            Console.WriteLine("            : ;   \\|    \\        \\ \\     :`             ");
            Console.SetCursorPosition(6, 23);
            Console.WriteLine("           }  ;  | /   \\        } \\     \\               ");
            Console.SetCursorPosition(6, 24);
            Console.WriteLine("            ;  ;  /_) \\_.=~~==.__//__.-`                ");
            Console.SetCursorPosition(6, 25);
            Console.WriteLine("             ;  ;  /| |           //                    ");
            Console.SetCursorPosition(6, 26);
            Console.WriteLine("              ;   ; /_|_____       {{                   ");
            Console.SetCursorPosition(6, 27);
            Console.WriteLine("                '=.    '=:__                            ");
            Console.SetCursorPosition(6, 28);
            Console.WriteLine("                     ==.____~:..                        ");
            Console.ResetColor();
        }

        public void PrintStego()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(6, 15);
            Console.WriteLine("                             .       .                            ");
            Console.SetCursorPosition(6, 16);
            Console.WriteLine("                            \\ '.   .` /                          ");
            Console.SetCursorPosition(6, 17);
            Console.WriteLine("                    .---.  >    < >    <  .---.                   ");
            Console.SetCursorPosition(6, 18);
            Console.WriteLine("                    |    /  / - ~ ~ - \\  \\    |                 ");
            Console.SetCursorPosition(6, 19);
            Console.WriteLine("                     ~-..-~             ~-..-~                    ");
            Console.SetCursorPosition(6, 20);
            Console.WriteLine("                /~~~/.`                    '.\\~~~\\              ");
            Console.SetCursorPosition(6, 21);
            Console.WriteLine("                 /__\\                        /__\\    .-^~~-.    ");
            Console.SetCursorPosition(6, 22);
            Console.WriteLine("                   \\  \\       /               /     \\    O  '. ");
            Console.SetCursorPosition(6, 23);
            Console.WriteLine("             /~~~/\\  }         |               '._.`    ˎ_____)  ");
            Console.SetCursorPosition(6, 24);
            Console.WriteLine("              /__\\    /        |     }       /          .----`   ");
            Console.SetCursorPosition(6, 25);
            Console.WriteLine("          |~~ˎ .`      /       |      /       |      .-`          ");
            Console.SetCursorPosition(6, 26);
            Console.WriteLine("  :ʇ :ʇ   '-..`      _ -/      |^ ~ - _/      |__.-~              ");
            Console.SetCursorPosition(6, 27);
            Console.WriteLine(" _||_||_ .-`     .-~     /     |        /     |                   ");
            Console.SetCursorPosition(6, 28);
            Console.WriteLine(">_ _ _ _ _ . - ~         |_____|        |_____|                   ");
            Console.ResetColor();
        }


        public void PrintTrano()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(6, 10);
            Console.WriteLine("                                         *~- --------::    ");
            Console.SetCursorPosition(6, 11);
            Console.WriteLine("                                        *  !=ˎ        *    ");
            Console.SetCursorPosition(6, 12);
            Console.WriteLine("                                        *  ˎ           !   ");
            Console.SetCursorPosition(6, 13);
            Console.WriteLine("                                       .;               ;  ");
            Console.SetCursorPosition(6, 14);
            Console.WriteLine("-..                            ..      -       . ......;   ");
            Console.SetCursorPosition(6, 15);
            Console.WriteLine("!ˎ;!!;                     ~! ~*.*     ;        *..::!     ");
            Console.SetCursorPosition(6, 16);
            Console.WriteLine(" ~;  .ˎˎ-~;~:~~~~~.   ~~:-~;:~-~~~~~~~!-         ~*ˎ~.     ");
            Console.SetCursorPosition(6, 17);
            Console.WriteLine("   !ˎ            ~!!!!!!!!!-          ˎ            ;!.     ");
            Console.SetCursorPosition(6, 18);
            Console.WriteLine("     :!                                .           -=      ");
            Console.SetCursorPosition(6, 19);
            Console.WriteLine("       -::                         ~   !   *-------|       ");
            Console.SetCursorPosition(6, 20);
            Console.WriteLine("         ;;ˎˎ       ˎ...           ;   ;  -.               ");
            Console.SetCursorPosition(6, 21);
            Console.WriteLine("            .;;     *;:~ˎ     :    ;   ; !==               ");
            Console.SetCursorPosition(6, 22);
            Console.WriteLine("              .ˎ:;;ˎ~..~!ˎ    ~    ˎ~ ~ˎ;!:.ˎ;.            ");
            Console.SetCursorPosition(6, 23);
            Console.WriteLine("                   ::::;*ˎ    ~     : -!= .:~~*            ");
            Console.SetCursorPosition(6, 24);
            Console.WriteLine("                        ;ˎ    ~      *-  *: ***:           ");
            Console.SetCursorPosition(6, 25);
            Console.WriteLine("                        ;ˎ    ~     ˎ!~-!-ˎ* .ˎ            ");
            Console.SetCursorPosition(6, 26);
            Console.WriteLine("                        ;ˎ   *-:::~~!    ;~-!              ");
            Console.SetCursorPosition(6, 27);
            Console.WriteLine("                        ;ˎ  -. ..  .:    ~*=*              ");
            Console.SetCursorPosition(6, 28);
            Console.WriteLine("                        ;ˎ ~!  ..  ;       .               ");
            Console.SetCursorPosition(6, 29);
            Console.WriteLine("                        ;ˎ:~   ..:-                        ");
            Console.SetCursorPosition(6, 30);
            Console.WriteLine("                        ;ˎ*    ..!                         ");
            Console.SetCursorPosition(6, 31);
            Console.WriteLine("                        ;ˎ*    ..!                         ");
            Console.SetCursorPosition(6, 32);
            Console.WriteLine("                        !;=;~  .;*;;                       ");
            Console.ResetColor();
        }

        public void PrintAlo()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(6, 10);
            Console.WriteLine("                                              ____        ");
            Console.SetCursorPosition(6, 11);
            Console.WriteLine("  ___                                      .-~. /_\" -._    ");
            Console.SetCursorPosition(6, 12);
            Console.WriteLine("`-._~-.                                  / /_ \"~o\\  :Y    ");
            Console.SetCursorPosition(6, 13);
            Console.WriteLine("      \\  \\                                / : \\~x.  ` ')  ");
            Console.SetCursorPosition(6, 14);
            Console.WriteLine("      ]  Y                              /  |  Y< ~-.__j   ");
            Console.SetCursorPosition(6, 15);
            Console.WriteLine("     /   !                        _.--~T : l  l<  /.-~    ");
            Console.SetCursorPosition(6, 16);
            Console.WriteLine("    /   /                 ____.--~ .   ` l /~\\ \\<|Y       ");
            Console.SetCursorPosition(6, 17);
            Console.WriteLine("   /   /             .-~~\" /| .    ',-~\\ \\L|       ");
            Console.SetCursorPosition(6, 18);
            Console.WriteLine("  /   /             /     .^   \\ Y~Y \\.^>/l_   \"--'       ");
            Console.SetCursorPosition(6, 19);
            Console.WriteLine(" /   Y           .-\"(  .  l__  j_j l_ / / ~_.- ~    .        ");
            Console.SetCursorPosition(6, 20);
            Console.WriteLine("Y    l          /    \\  )    ~~~.\" / `/ \"~ / \\.__/l_       ");
            Console.SetCursorPosition(6, 21);
            Console.WriteLine("|     \\     _.-\"      ~-            __ l  :  l._Z~-.___.--~");
            Console.SetCursorPosition(6, 22);
            Console.WriteLine("|      ~---~           /   ~~\"-- -\\_  ' __[>               ");
            Console.SetCursorPosition(6, 23);
            Console.WriteLine("l  .                _.^   ___     _>-y~                   ");
            Console.SetCursorPosition(6, 24);
            Console.WriteLine(" \\  \\     .      .-~   .-~   ~>--\" /                   ");
            Console.SetCursorPosition(6, 25);
            Console.WriteLine("  \\  ~---\" /     ./ _.- '                               ");
            Console.SetCursorPosition(6, 26);
            Console.WriteLine("   \" -., _____., _  _.--~\\     _.- ~                    ");
            Console.SetCursorPosition(6, 27);
            Console.WriteLine("               ~~     (   _}                              ");
            Console.SetCursorPosition(6, 28);
            Console.WriteLine("                      `. ~(                               ");
            Console.SetCursorPosition(6, 29);
            Console.WriteLine("                        )  \\                              ");
            Console.SetCursorPosition(6, 30);
            Console.WriteLine("                  /,`--'~\\--'~\\                           ");
            Console.ResetColor();
        }

        public void PrintAnkilo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(6, 15);
            Console.WriteLine("                      /~~~~~~~~~~~~\\_                ");
            Console.SetCursorPosition(6, 16);
            Console.WriteLine(" _+=+_             _[~  /~~~~~~~~~~~~\\_              ");
            Console.SetCursorPosition(6, 17);
            Console.WriteLine("{\"\"|\"\"}         [~~~    [~   /~~~~~~~~~\\_            ");
            Console.SetCursorPosition(6, 18);
            Console.WriteLine(" \"\"\":-'~[~[~\"~[~  ((++     [~  _/~~~~~~~~\\_          ");
            Console.SetCursorPosition(6, 19);
            Console.WriteLine("      '=_   [    ,==, ((++    [    /~~~~~~~\\-~~~-.   ");
            Console.SetCursorPosition(6, 20);
            Console.WriteLine("         ~-_ _=+-(   )/   ((++  .~~~.[~~~~(  {@} \\`. ");
            Console.SetCursorPosition(6, 21);
            Console.WriteLine("                 /   }\\ /     (     }     (   .   ''}");
            Console.SetCursorPosition(6, 22);
            Console.WriteLine("                (  .+   \\ /  //     )    / .,  \"\"\"\"/ ");
            Console.SetCursorPosition(6, 23);
            Console.WriteLine("                \\  \\     \\ (   .+~~\\_  /.= /'\"\"\"\"   ");
            Console.SetCursorPosition(6, 24);
            Console.WriteLine("                <\"_V_\">      \\  \\    ~~~~~~\\  \\    ");
            Console.SetCursorPosition(6, 25);
            Console.WriteLine("                              \\  \\          \\  \\   ");
            Console.SetCursorPosition(6, 26);
            Console.WriteLine("                              <\"_V_\">        <\"_V_\"> ");
            Console.ResetColor();
        }
      
     
        public void PrintPtera()
        {
            Console.ForegroundColor= ConsoleColor.DarkGray;
            Console.SetCursorPosition(6, 15);
            Console.WriteLine("                           <\\              _                ");
            Console.SetCursorPosition(6, 16);
            Console.WriteLine("                            \\          _/{                 ");
            Console.SetCursorPosition(6, 17);
            Console.WriteLine("                     _       \\       _-   -_               ");
            Console.SetCursorPosition(6, 18);
            Console.WriteLine("                   /{        / `\\   _-     - -_             ");
            Console.SetCursorPosition(6, 19);
            Console.WriteLine("                 _~  =      ( @  \\ -        -  -_           ");
            Console.SetCursorPosition(6, 20);
            Console.WriteLine("               _- -   ~-_   \\( =\\ \\           -  -_         ");
            Console.SetCursorPosition(6, 21);
            Console.WriteLine("             _~  -       ~_ | 1 :\\ \\      _-~-_ -  -_       ");
            Console.SetCursorPosition(6, 22);
            Console.WriteLine("           _-   -          ~  |V: \\ \\  _-~     ~-_-  -_     ");
            Console.SetCursorPosition(6, 23);
            Console.WriteLine("        _-~   -            /  | :  \\ \\            ~-_- -_   ");
            Console.SetCursorPosition(6, 24);
            Console.WriteLine("     _-~    -   _.._      {   | : _-``               ~- _-_ ");
            Console.SetCursorPosition(6, 25);
            Console.WriteLine("  _-~   -__..--~    ~-_  {   : \\:}                          ");
            Console.SetCursorPosition(6, 26);
            Console.WriteLine("=~__.--~~              ~-_\\  :  /                           ");
            Console.SetCursorPosition(6, 27);
            Console.WriteLine("                           \\ : /__                          ");
            Console.SetCursorPosition(6, 28);
            Console.WriteLine("                          /`Y'--\\                          ");
            Console.SetCursorPosition(6, 29);
            Console.WriteLine("                         <+      \\                         ");
            Console.SetCursorPosition(6, 30);
            Console.WriteLine("                          \\      WWW                       ");
            Console.SetCursorPosition(6, 31);
            Console.WriteLine("                          MMM                               ");
            Console.ResetColor();

        }

        public void PrintGiga()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("                                               ;::-~--~-:;            ");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine("                                            .:~~~-      ~:::::,       ");
            Console.SetCursorPosition(4, 10);
            Console.WriteLine("                                         .-~--~           ,--,~~      ");
            Console.SetCursorPosition(4, 11);
            Console.WriteLine("                                       .,,-                    ;,,,,  ");
            Console.SetCursorPosition(4, 12);
            Console.WriteLine("                                   -.-,--          .;;           --~; ");
            Console.SetCursorPosition(4, 13);
            Console.WriteLine("                                .,,;-,             --            -,~! ");
            Console.SetCursorPosition(4, 14);
            Console.WriteLine("                            ,*!:,,,                               :*! ");
            Console.SetCursorPosition(4, 15);
            Console.WriteLine("           -;:~;*;!;:~;:-:;;~*!                                   :;  ");
            Console.SetCursorPosition(4, 16);
            Console.WriteLine("         ,-~!::-                                                ~..-  ");
            Console.SetCursorPosition(4, 17);
            Console.WriteLine("       ,..,,                                            ....... ./    ");
            Console.SetCursorPosition(4, 18);
            Console.WriteLine("      ,,,,,,-                                     -,~-.,,             ");
            Console.SetCursorPosition(4, 19);
            Console.WriteLine("   :,--,-,...,,,-. ,                        ,-;,,--   -::-.,,,.       ");
            Console.SetCursorPosition(4, 20);
            Console.WriteLine("  !~-~-..---~    ,-,. .,~                   ..~;;;!~~:~   ::~;!:      ");
            Console.SetCursorPosition(4, 21);
            Console.WriteLine("  ;-.-. .          ,,. ;~                .. ..,    -~::~--   -~-      ");
            Console.SetCursorPosition(4, 22);
            Console.WriteLine("   -,~                 ;~                  -;            !;;;.        ");
            Console.SetCursorPosition(4, 23);
            Console.WriteLine("   . .                 ;:                   -!!          . ..         ");
            Console.SetCursorPosition(4, 24);
            Console.WriteLine("                       -,~                   -~.-                     ");
            Console.SetCursorPosition(4, 25);
            Console.WriteLine("                        ~!,                  *,,:                     ");
            Console.SetCursorPosition(4, 26);
            Console.WriteLine("                        ,:~-                ,:~~.                     ");
            Console.SetCursorPosition(4, 27);
            Console.WriteLine("                       :,-~                 ~ ,                       ");
            Console.SetCursorPosition(4, 28);
            Console.WriteLine("                       ;~::!         ... *:*-                         ");
            Console.SetCursorPosition(4, 29);
            Console.WriteLine("                       :~-:.   ~:!-:                                  ");
            Console.SetCursorPosition(4, 30);
            Console.WriteLine("                       .:: ,   ,~!..                                  ");
            Console.SetCursorPosition(4, 31);
            Console.WriteLine("                       :;;,~:::~;*,---,;-:                            ");
            Console.SetCursorPosition(4, 32);
            Console.WriteLine("                        -;~-,~-:~!::;:~;;~                            ");
            Console.SetCursorPosition(4, 33);
            Console.WriteLine("                        ~!.----:~*;;;!!;;,                            ");
            Console.ResetColor();
        }

        
    }
}
