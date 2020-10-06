﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Order0
{
    [Serializable]
    public class Order
    {
        public OrderDetails myOD { get; set; }
        public int o_id { get; set; }
        public int totalPrice { get; set; }
        public void printAll() {
            Console.WriteLine("订货id: " + o_id + "/n"
                + myOD.toString()+
                "/n"+"_____________________________");
        }
        public void updateOrder(OrderDetails myOD) {
            this.myOD = myOD;
        }
        public bool Equals(Order o) {
            return o.myOD.Equals(this.myOD) && o.o_id == this.o_id;
        }
        public Order(OrderDetails myOD, int o_id) {
            this.myOD = myOD;
            this.o_id = o_id;
            totalPrice=getAllPrice();
           
        }
        public Order()
        {
            this.myOD = null;
            this.o_id = -1;
            totalPrice = 0;

        }
        public int getAllPrice() {
            return myOD.getAllPrice();
        }
    }

}
