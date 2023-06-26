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
    }
}
