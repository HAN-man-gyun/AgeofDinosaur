using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_project
{
    public class PrimitiveMan
    {
        public string name;
        public int maxHp;
        public int hp;
        public int power;
        public int luck;
        public int fossils;
        public int friendship;

        public void InitPrimitive(string name, int maxHp, int hp,int power, int luck, int fossils, int friendship)
        {
            this.name = name;
            this.maxHp = maxHp;
            this.hp = hp;
            this.power = power;
            this.luck = luck;
            this.fossils = fossils;
            this.friendship = friendship;
        }

        public void PrintPrimi1()
        {
            Console.SetCursorPosition(30, 15);
            Console.Write("   \\\\|||///    ");
            Console.SetCursorPosition(30, 16);
            Console.Write(" .  =======     ");
            Console.SetCursorPosition(30, 17);
            Console.Write("/ \\| O   O |    ");
            Console.SetCursorPosition(30, 18);
            Console.Write("\\ / \\`___'/     ");
            Console.SetCursorPosition(30, 19);
            Console.Write(" #   _| |_      ");
            Console.SetCursorPosition(30, 20);
            Console.Write("(#) (     )     ");
            Console.SetCursorPosition(30, 21);
            Console.Write(" #\\//|x x|\\    ");
            Console.SetCursorPosition(30, 22);
            Console.Write(" #\\/(  *  )/    ");
            Console.SetCursorPosition(30, 23);
            Console.Write(" #   =====      ");
            Console.SetCursorPosition(30, 24);
            Console.Write(" #   (   )      ");
            Console.SetCursorPosition(30, 25);
            Console.Write(" #   || ||      ");
            Console.SetCursorPosition(30, 26);
            Console.Write(".#---'| |`----. ");
            Console.SetCursorPosition(30, 27);
            Console.Write("`#----' `-----' ");
        }

        public void PrintPrimi2()
        {

            Console.SetCursorPosition(25, 6);
            Console.WriteLine("                                  ~;:                                ");
            Console.SetCursorPosition(25, 7);
            Console.WriteLine("                              ~;;,...,;;:                            ");
            Console.SetCursorPosition(25, 8);
            Console.WriteLine("                       ,:!~----,       .-----;;-                     ");
            Console.SetCursorPosition(25, 9);
            Console.WriteLine("                     .!!-                     .!!.                   ");
            Console.SetCursorPosition(25, 10);
            Console.WriteLine("                   ;;!:                         ~;;;.                ");
            Console.SetCursorPosition(25, 11);
            Console.WriteLine("                 ,!;                               ;!-               ");
            Console.SetCursorPosition(25, 12);
            Console.WriteLine("                 ~!     ,-;!!!!!!!!!!!!!!!!!!-,     !;               ");
            Console.SetCursorPosition(25, 13);
            Console.WriteLine("                :;;-   ;;-        ~!;        ,;!.  ,;;!              ");
            Console.SetCursorPosition(25, 14);
            Console.WriteLine("              ,!;     -!;:::::::::;!;:::::::::;!:     ;!-            ");
            Console.SetCursorPosition(25, 15);
            Console.WriteLine("              -!.      ,!!--------, .--------;!-.      !:            ");
            Console.SetCursorPosition(25, 16);
            Console.WriteLine("              .:!,.     !:        ...        -!      .;;-            ");
            Console.SetCursorPosition(25, 17);
            Console.WriteLine("                :!:     !; -!!!!!!!!!!!!!!!~ ~!     -!;              ");
            Console.SetCursorPosition(25, 18);
            Console.WriteLine("                !:    ~:!~.....         .....-!::    ~!,             ");
            Console.SetCursorPosition(25, 19);
            Console.WriteLine("                :!-  ~!~         ,;:;-         -!:  -!!.             ");
            Console.SetCursorPosition(25, 20);
            Console.WriteLine("                 -::!!!.  .!.              !,   ;!!;:~               ");
            Console.SetCursorPosition(25, 21);
            Console.WriteLine("                     !!.  ;!~   ;~   -;   ,!!   ;!                   ");
            Console.SetCursorPosition(25, 22);
            Console.WriteLine("                   ~~!!.  ;!~   !!   :!   ,!;   ;!~~~~~.             ");
            Console.SetCursorPosition(25, 23);
            Console.WriteLine("         .,,-!!;~~~~~~~;!!;!~   !!   :!   ,!!!!!~~~~~~!::!!:,,,      ");
            Console.SetCursorPosition(25, 24);
            Console.WriteLine("       ,!;;,              -;~  ,!!   :!:  -!~        .!,     ;;!-    ");
            Console.SetCursorPosition(25, 25);
            Console.WriteLine("     :;:.                   -!!:!!   :!!;!:.    :;   .!,       .!;,  ");
            Console.SetCursorPosition(25, 26);
            Console.WriteLine("    :!,                          -;!!~.         ,,   .!,         ;!. ");
            Console.SetCursorPosition(25, 27);
            Console.WriteLine("   -!;                          ,;::       !-   ::   .!,         ~!: ");
            Console.SetCursorPosition(25, 28);
            Console.WriteLine("   -!!!!!!-                   !!!    :!    !.   ~:   .!,    .!!!!!!: ");
            Console.SetCursorPosition(25, 29);
            Console.WriteLine("   -!:....      !-       .::!~.      ~!    :.   --   .!,     .  ..!: ");
            Console.SetCursorPosition(25, 30);
            Console.WriteLine("   -!;----.     !:----;!:--.    --   ,-   .!~   :;   .!,     -----!: ");
            Console.SetCursorPosition(25, 31);
            Console.WriteLine("   -!;::::,     !;:~ !!.   .    !;   :!    .     .   .!,    .:::::!: ");
            Console.SetCursorPosition(25, 32);
            Console.WriteLine("   -!:          !-   !!.  ;!~             ,!;   ;;   .!,          !: ");
            Console.SetCursorPosition(25, 33);
            Console.WriteLine("   ,!!!!!!!!!!!!!!!!!!;!!!!!!!!!!!!!!!!!!!!!!!!!;!!!!!!!!!!!!!!!!!!- ");
        }
    }
}
