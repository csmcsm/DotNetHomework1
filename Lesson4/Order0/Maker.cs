using System;
using System.Collections.Generic;
using System.Text;

namespace Order0
{
    class Maker
    {
        public Item makeItem1() {
            return new Item("A", 0, 100);
        }
        public Item makeItem2()
        {
            return new Item("B", 1, 2100);
        }
        public Item makeItem3()
        {
            return new Item("C", 2, 500);
        }
      
    }
}
