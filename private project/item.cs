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
        public int price;
        public int power ;
        public string script;
        public void InitialItem(string name,int price,int power,string script)
        {
            this.name = name;
            this.price = price;
            this.power = power;
            this.script = script;
        }
    }
}
