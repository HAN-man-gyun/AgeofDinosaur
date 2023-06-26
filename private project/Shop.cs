using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_project
{
    public class Shop : item
    {
        List<item> items = new List<item>();
        public void InitializeItem()
        {
            item item1 = new item();
            item1.InitialItem(" ", 100, 0, " ");
            items.Add(item1);

            item item2 = new item();
            item2.InitialItem(" ", 0, 100, " ");
            items.Add(item2);
        }

        public void Buy()
        {

        }
        

    }
}
