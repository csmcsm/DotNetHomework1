using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chatter;
using lesson3;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public void sendNewOrder(string name, string item, int id)
        {
            DataMgr dataMgr = new DataMgr();
            Client c = new Client(name, id);
            string[] items = item.Split(',');
            Item[] its = Maker.makeItem(items);
            OrderDetails ods = new OrderDetails(its, c);
            Order o = new Order(ods, id);
            dataMgr.createDetails(SerHelper.orderSerialize(o), id);
        }
        [HttpGet]
        public void updateNewOrder(int id)
        {
            DataMgr dataMgr = new DataMgr();
            Client c = new Client("Women", 11);
            Item[] its = { Maker.makeItem3() };
            OrderDetails ods = new OrderDetails(its, c);
            Order o = new Order(ods, id);
            dataMgr.updataDetails(SerHelper.orderSerialize(o), id);
        }
        [HttpGet]
        public void deleteNewOrder(int id)
        {
            DataMgr dataMgr = new DataMgr();
            dataMgr.deleteDetails(id);
        }
    }
}
