using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace lesson3
{
    public class OrderService
    {
        public List<Order> orders;
        public void Export()
        {

            SerHelper.serialize(orders);
        }
        public void Import()
        {
            orders = SerHelper.deserialize();
        }
        public void printAll()
        {
            for (int i = 0; i < orders.Count; i++)
            {
                orders[i].printAll();
            }
        }
        public void deleteOrder(int d_o_id)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].o_id == d_o_id)
                {
                    orders.RemoveAt(i);
                    Console.WriteLine("删除成功");
                    return;
                }
            }
            Console.WriteLine("不存在这一订单");
        }

        public void updateOrder(int d_o_id, OrderDetails myOD)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].o_id == d_o_id)
                {
                    orders[i].updateOrder(myOD);
                    Console.WriteLine("修改成功");
                    return;
                }
            }
            Console.WriteLine("不存在这一订单");
        }
     

    
    public string select(int num)
    {

        var longwords = from o in orders
                        where o.o_id == num
                        orderby o.totalPrice
                        select o;
            string s = "";
            foreach (var o in longwords) {
                Order od = (Order)o;
                s += o.printAll();
            }
            return s;

    }
        public void sort() {
            var longwords = from o in orders
                            orderby o.o_id
                            select o;
            List<Order> os = new List<Order>();
            foreach (var o in longwords)
            {
                os.Add(o);
            }
        }
        public void sort(int i)
        {
            var longwords = orders.
               OrderBy(o => o.totalPrice);
            List<Order> os = new List<Order>();
            foreach (var o in longwords)
            {
                os.Add(o);
            }
        }
    }

}

