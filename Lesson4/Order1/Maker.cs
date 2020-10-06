using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3
{
    class Maker
    {
        public static Item[] makeItem(string[] items)
        {
            Item[] it = new Item[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                switch (items[i])
                {
                    case "A":
                        it[i] = makeItem1();
                        break;
                    case "B":
                        it[i] = makeItem2();
                        break;
                    case "C":
                        it[i] = makeItem3();
                        break;
                    default:
                        it[i] = null;
                        break;
                }
            }
            return it;
        }
        public static Item makeItem1() {
            return new Item("A", 0, 100);
        }
        public static Item makeItem2()
        {
            return new Item("B", 1, 2100);
        }
        public static Item makeItem3()
        {
            return new Item("C", 2, 500);
        }
      
    }
}
