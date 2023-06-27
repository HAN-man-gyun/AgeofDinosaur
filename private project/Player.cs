using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace private_project
{
    public class Player
    {
        public string name;
        public string weaponName;
        public int weaponPower;
        public int maxHp;
        public int hp;
        public int luck;
        public int fossils;
        public int eggCount;
        
        public void IntiailizePlayer(string name, string weaponname,int weaponpower, int maxHp, int hp,int luck, int fossils ,int eggcount)
        {
            this.name = name;
            this.weaponName = weaponname;
            this.weaponPower = weaponpower;
            this.maxHp = maxHp;
            this.hp = hp;
            this.luck = luck;
            this.fossils = fossils;
            this.eggCount = eggcount;
        }

        public void PrintInventory()
        {
            Console.SetCursorPosition(3, 20);
            Console.WriteLine("유저 인벤토리");
            Console.SetCursorPosition(3, 22);
            Console.WriteLine("{0}");
            Console.SetCursorPosition(3, 24);
            Console.WriteLine("{0}");
            Console.SetCursorPosition(3, 26);
            Console.WriteLine("{0}");
            Console.SetCursorPosition(3, 28);
            Console.WriteLine("{0}");
            Console.SetCursorPosition(3, 30);
            Console.WriteLine("{0}");
            Console.SetCursorPosition(30, 22);
            Console.WriteLine("{0}");
            Console.SetCursorPosition(30, 24);
            Console.WriteLine("{0}");
            Console.SetCursorPosition(30, 26);
            Console.WriteLine("{0}");
            Console.SetCursorPosition(30, 28);
            Console.WriteLine("{0}");
            Console.SetCursorPosition(30, 30);
            Console.WriteLine("{0}");

        }
    }
}
