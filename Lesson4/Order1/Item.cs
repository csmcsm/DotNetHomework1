using System;
using System.Collections.Generic;
using System.Text;


namespace lesson3
{
    [Serializable]
    public class Item
    {
        string name;
        int i_id;
        public int price { get; set; }
        public Item(string name, int i_id, int price)
        {
            this.name = name;
            this.i_id = i_id;
            this.price = price;
        }
        public Item() { 
        }
        public string toString()
        {
            return "商品名：" + name +
         " 编货id:  " + i_id +
                " 价格：" + price
                + "\n";
        }

    }
}
