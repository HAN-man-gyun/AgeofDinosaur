using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_project
{
    public class item
    {
        public string name;
        public int metal;
        public int darkmatter;
        public string script;
        public void InitialItem(string name,int metal,int darkmatter,string script)
        {
            this.name = name;
            this.metal = metal;
            this.darkmatter = darkmatter;
            this.script = script;
        }
    }
}
