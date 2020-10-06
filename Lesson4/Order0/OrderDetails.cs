using System;
using System.Collections.Generic;
using System.Text;

namespace Order0
{
    [Serializable]
    public class OrderDetails
    {
        Item[] items;
        Client client;
        public string toString() {
            string s="";
            for (int i = 0; i < items.Length; i++) {
                s += items[i].toString();
            }
            s += client.toString();
            return s;
        }
        public bool Equals(OrderDetails od) {
            if (od.toString() == this.toString()) {
                return true;
            }
            return false;
        }
        public int getAllPrice() {
            int p = 0;
            for (int i = 0; i < items.Length; i++)
            {
                p += items[i].price;
            }
            return p;
        }
        public OrderDetails(Item[] items, Client client) {
            this.items = items;
            this.client = client;
        }
        public OrderDetails()
        {
            this.items = null;
            this.client = null;
        }
    }

}
