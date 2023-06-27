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

        public void PrintRapter()
        {
            Console.WriteLine("                            ___......__             _        ");
            Console.WriteLine("                        _.-'           ~-_       _.=a~~-_    ");
            Console.WriteLine("--=====-.-.-_----------~   .--.       _   -.__.-~ ( ___===>  ");
            Console.WriteLine("              '''--...__  (    \\_\\ { )       _.-~          ");
            Console.WriteLine("                        =_ ~_  \\-~~~//~~~~-=-~              ");
            Console.WriteLine("                         |-=-~_ \\   \\                      ");
            Console.WriteLine("                         |_/   =. )   ~}                     ");
            Console.WriteLine("                         |}      ||                          ");
            Console.WriteLine("                        //       ||                          ");
            Console.WriteLine("                      _//        {{                          ");
            Console.WriteLine("                   '='~'          \\_    =                   ");
            Console.WriteLine("                                   ~~'                       ");
        }
        public void PrintTri()
        {
            Console.WriteLine("                      . - ~ ~ ~ - ._                       ");
            Console.WriteLine("                   .-~               ~-.    .__       ..   ");
            Console.WriteLine("                 .`                     ~.}`   /     \\))   ");
            Console.WriteLine("                \\   \\     /               }     {   \\\\    ");
            Console.WriteLine("               \\   }       |              }      ^~~\\   \\)");
            Console.WriteLine("              \\    (       |         .-ˎ  }      ~@- ~-.`\\ ");
            Console.WriteLine("            .`      / /    |        :    )   }_ (     ___) ");
            Console.WriteLine("          .`      _ -/ /   \\       _| \\ \\_     .~-_.----`  ");
            Console.WriteLine("     _ -~     .-~     / +  )~~~--~~ |\\ \\  ~~----~~         ");
            Console.WriteLine("._-_~_ _ . -~          \\  \\         /  /                   ");
            Console.WriteLine("                      (  \\_          /  /__                ");
            Console.WriteLine("                       /___<.         '.___<.              ");
        }

        public void PrintAnkilo()
        {

            Console.WriteLine("                      /~~~~~~~~~~~~\\_                ");
            Console.WriteLine(" _+=+_             _[~  /~~~~~~~~~~~~\\_              ");
            Console.WriteLine("{\"\"|\"\"}         [~~~    [~   /~~~~~~~~~\\_            ");
            Console.WriteLine(" \"\"\":-'~[~[~\"~[~  ((++     [~  _/~~~~~~~~\\_          ");
            Console.WriteLine("      '=_   [    ,==, ((++    [    /~~~~~~~\\-~~~-.   ");
            Console.WriteLine("         ~-_ _=+-(   )/   ((++  .~~~.[~~~~(  {@} \\`. ");
            Console.WriteLine("                 /   }\\ /     (     }     (   .   ''}");
            Console.WriteLine("                (  .+   \\ /  //     )    / .,  \"\"\"\"/ ");
            Console.WriteLine("                \\  \\     \\ (   .+~~\\_  /.= /'\"\"\"\"   ");
            Console.WriteLine("                <\"_V_\">      \\  \\    ~~~~~~\\  \\    ");
            Console.WriteLine("                              \\  \\          \\  \\   ");
            Console.WriteLine("                              <\"_V_\">        <\"_V_\"> ");
        }
        public void PrintStego()
        {
            Console.WriteLine("                             .       .                            ");
            Console.WriteLine("                            \\ '.   .` /                          ");
            Console.WriteLine("                    .---.  >    < >    <  .---.                   ");
            Console.WriteLine("                    |    /  / - ~ ~ - \\  \\    |                 ");
            Console.WriteLine("                     ~-..-~             ~-..-~                    ");
            Console.WriteLine("                /~~~/.`                    '.\\~~~\\              ");
            Console.WriteLine("                 /__\\                        /__\\    .-^~~-.    ");
            Console.WriteLine("                   \\  \\       /               /     \\    O  '. ");
            Console.WriteLine("             /~~~/\\  }         |               '._.`    ˎ_____)  ");
            Console.WriteLine("              /__\\    /        |     }       /          .----`   ");
            Console.WriteLine("          |~~ˎ .`      /       |      /       |      .-`          ");
            Console.WriteLine("  :ʇ :ʇ   '-..`      _ -/      |^ ~ - _/      |__.-~              ");
            Console.WriteLine(" _||_||_ .-`     .-~     /     |        /     |                   ");
            Console.WriteLine(">_ _ _ _ _ . - ~         |_____|        |_____|                   ");
        }

        public void PrintPtera()
        {
            Console.WriteLine("                           <\\              _                ");
            Console.WriteLine("                            \\          _/{                 ");
            Console.WriteLine("                     _       \\       _-   -_               ");
            Console.WriteLine("                   /{        / `\\   _-     - -_             ");
            Console.WriteLine("                 _~  =      ( @  \\ -        -  -_           ");
            Console.WriteLine("               _- -   ~-_   \\( =\\ \\           -  -_         ");
            Console.WriteLine("             _~  -       ~_ | 1 :\\ \\      _-~-_ -  -_       ");
            Console.WriteLine("           _-   -          ~  |V: \\ \\  _-~     ~-_-  -_     ");
            Console.WriteLine("        _-~   -            /  | :  \\ \\            ~-_- -_   ");
            Console.WriteLine("     _-~    -   _.._      {   | : _-``               ~- _-_ ");
            Console.WriteLine("  _-~   -__..--~    ~-_  {   : \\:}                          ");
            Console.WriteLine("=~__.--~~              ~-_\\  :  /                           ");
            Console.WriteLine("                           \\ : /__                          ");
            Console.WriteLine("                          /`Y'--\\                          ");
            Console.WriteLine("                         <+      \\                         ");
            Console.WriteLine("                          \\      WWW                       ");
            Console.WriteLine("                          MMM                               ");

        }

        public void PrintPhy()
        {
            Console.WriteLine("                                             _          ");
            Console.WriteLine("                                             //         ");
            Console.WriteLine("                                              //        ");
            Console.WriteLine("                                               )/__     ");
            Console.WriteLine("                                             .-~  ɒ-~._ ");
            Console.WriteLine("                     _.=~~~~=.._           .`    (_____{");
            Console.WriteLine("                  .='           ~=._      \\    _-~      ");
            Console.WriteLine("              _.=:   .=.            ~=._.`    \\         ");
            Console.WriteLine("             (\\ :   \\   )         __         -          ");
            Console.WriteLine("             : :   |     )       }  )      .~           ");
            Console.WriteLine("            : ;   \\|    \\        \\ \\     :`             ");
            Console.WriteLine("           }  ;  | /   \\        } \\     \\               ");
            Console.WriteLine("            ;  ;  /_) \\_.=~~==.__//__.-`                ");
            Console.WriteLine("             ;  ;  /| |           //                    ");
            Console.WriteLine("              ;   ; /_|_____       {{                   ");
            Console.WriteLine("                '=.    '=:__                            ");
            Console.WriteLine("                     ==.____~:..                        ");
        }
        public void PrintBra()
        {
            Console.WriteLine("                                                                        _   ");
            Console.WriteLine("                                                                      ˎ`p~. ");
            Console.WriteLine("                                                                     \\  ˎ__{");
            Console.WriteLine("                                                                    \\ '\\    ");
            Console.WriteLine("                                                                   \\  \\     ");
            Console.WriteLine("                                                                  \\  \\      ");
            Console.WriteLine("                                              __.__            _.`  \\       ");
            Console.WriteLine("                                       _..--~~     ~~==._  _.-~    \\        ");
            Console.WriteLine("                                    .-~                  '        \\         ");
            Console.WriteLine("                                  .`                _-   -_      \\          ");
            Console.WriteLine("                                 \\  .    -.        }       /    \\           ");
            Console.WriteLine("                                \\  ;       )      }  /      | .`            ");
            Console.WriteLine("                              \\'   :       )       /  /     |`              ");
            Console.WriteLine("                            \\       /      |        /  |    \\               ");
            Console.WriteLine("                          \\      .-^|     \\.______.-`/     |                ");
            Console.WriteLine("                       _\\      .`   |     )           /|   |                ");
            Console.WriteLine("  __=_..----.._____..-`    _.'      \\   \\~            ||   |                ");
            Console.WriteLine(" '''~~~~~~~~~-.__________.-~=      \\   \\_             /|   |                ");
            Console.WriteLine("                                  }______o.            /___'o.              ");
        }
        public void PrintAlo()
        {
            Console.WriteLine("                                              ____        ");
            Console.WriteLine("  ___                                      .-~. /_\" -._    ");
            Console.WriteLine("`-._~-.                                  / /_ \"~o\\  :Y    ");
            Console.WriteLine("      \\  \\                                / : \\~x.  ` ')  ");
            Console.WriteLine("      ]  Y                              /  |  Y< ~-.__j   ");
            Console.WriteLine("     /   !                        _.--~T : l  l<  /.-~    ");
            Console.WriteLine("    /   /                 ____.--~ .   ` l /~\\ \\<|Y       ");
            Console.WriteLine("   /   /             .-~~\" /| .    ',-~\\ \\L|       ");
            Console.WriteLine("  /   /             /     .^   \\ Y~Y \\.^>/l_   \"--'       ");
            Console.WriteLine(" /   Y           .-\"(  .  l__  j_j l_ / / ~_.- ~    .        ");
            Console.WriteLine("Y    l          /    \\  )    ~~~.\" / `/ \"~ / \\.__/l_       ");
            Console.WriteLine("|     \\     _.-\"      ~-            __ l  :  l._Z~-.___.--~");
            Console.WriteLine("|      ~---~           /   ~~\"-- -\\_  ' __[>               ");
            Console.WriteLine("l  .                _.^   ___     _>-y~                   ");
            Console.WriteLine(" \\  \\     .      .-~   .-~   ~>--\" /                   ");
            Console.WriteLine("  \\  ~---\" /     ./ _.- '                               ");
            Console.WriteLine("   \" -., _____., _  _.--~\\     _.- ~                    ");
            Console.WriteLine("               ~~     (   _}                              ");
            Console.WriteLine("                      `. ~(                               ");
            Console.WriteLine("                        )  \\                              ");
            Console.WriteLine("                  /,`--'~\\--'~\\                           ");
        }
        public void PrintTrano()
        {
            Console.WriteLine("                                         *~-  -:: ");
            Console.WriteLine("                                        *  !=ˎ  * ");
            Console.WriteLine("                                        *  ˎ     !");
            Console.WriteLine("                                       .;        ;");
            Console.WriteLine("-..                            ..      -    .....;");
            Console.WriteLine("!ˎ;!!;                     ~! ~*.*     ;    *..::!");
            Console.WriteLine(" ~;  .ˎˎ-~;~:~~~~~.   ~~:-~;:~-~~~~~~~!-     ~*ˎ~.");
            Console.WriteLine("   !ˎ            ~!!!!!!!!!-          ˎ       ;!. ");
            Console.WriteLine("     :!                                .       -= ");
            Console.WriteLine("       -::                         ~   !   *----  ");
            Console.WriteLine("         ;;ˎˎ       ˎ...           ;   ;  -.      ");
            Console.WriteLine("            .;;     *;:~ˎ     :    ;   ; !==      ");
            Console.WriteLine("              .ˎ:;;ˎ~..~!ˎ    ~    ˎ~ ~ˎ;!:.ˎ;.   ");
            Console.WriteLine("                   ::::;*ˎ    ~     : -!= .:~~*   ");
            Console.WriteLine("                        ;ˎ    ~      *-  *: ***:  ");
            Console.WriteLine("                        ;ˎ    ~     ˎ!~-!-ˎ* .ˎ   ");
            Console.WriteLine("                        ;ˎ   *-:::~~!    ;~-!     ");
            Console.WriteLine("                        ;ˎ  -. ..  .:    ~*=*     ");
            Console.WriteLine("                        ;ˎ ~!  ..  ;       .      ");
            Console.WriteLine("                        ;ˎ:~   ..:-               ");
            Console.WriteLine("                        ;ˎ*    ..!                ");
            Console.WriteLine("                        ;ˎ*    ..!                ");
            Console.WriteLine("                        !;=;~  .;*;;              ");
        }
    }
}
