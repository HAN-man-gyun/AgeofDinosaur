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
    }
}
