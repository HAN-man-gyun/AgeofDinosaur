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
        public int luck;
        public int fossils;

        public void InitPrimitive(string name, int maxHp, int hp, int luck, int fossils)
        {
            this.name = name;
            this.maxHp = maxHp;
            this.hp = hp;
            this.luck = luck;
            this.fossils = fossils;
        }
    }
}
