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
        public void IntiailizePlayer(string name, string weaponname,int weaponpower, int maxHp, int hp,int luck, int fossils  )
        {
            this.name = name;
            this.weaponName = weaponname;
            this.weaponPower = weaponpower;
            this.maxHp = maxHp;
            this.hp = hp;
            this.luck = luck;
            this.fossils = fossils;
        }
    }
}
