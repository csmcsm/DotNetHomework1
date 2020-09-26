using Microsoft.VisualStudio.TestTools.UnitTesting;
using lesson3;
using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3.Tests
{
   
    public class OrderServiceTests
    {
        
        public void ExportTest()
        {
            OrderService os = new OrderService();
            os.orders = null;
            os.Export();
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService os = new OrderService(); 
            os.Import();
        }

        [TestMethod()]
        public void printAllTest()
        {
            OrderService os = new OrderService();
            os.orders = null;
            os.printAll();
        }

        [TestMethod()]
        public void deleteOrderTest()
        {
            OrderService os = new OrderService();
            os.orders = null;
            os.deleteOrder(12);
        }

        [TestMethod()]
        public void updateOrderTest()
        {
            OrderService os = new OrderService();
            os.orders = null;
            os.updateOrder(1,new OrderDetails(null,null));
        }

        [TestMethod()]
        public void selectTest()
        {
            OrderService os = new OrderService();
            os.orders = null;
            os.select(1);
        }

        [TestMethod()]
        public void sortTest()
        {
            OrderService os = new OrderService();
            os.orders = null;
            os.sort();
        }

        [TestMethod()]
        public void sortTest1()
        {
            OrderService os = new OrderService();
            os.orders = null;
            os.sort(1);
        }
    }
}