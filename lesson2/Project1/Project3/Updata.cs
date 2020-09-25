using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project3
{
    class Updata
    {

        public static void Main(string[] args) {
         
            TickHelper tick1 = new TickHelper();
            TickHelper tick2 = new TickHelper();
            tick1.ontick += new TickHelper.tickHandler(TickHelper.ticking);
            tick2.ontick += new TickHelper.tickHandler(TickHelper.alarming);
            int lasting = 10;
            while (true) {
                if (lasting <= 0)
                {
                    tick2.tick();
                }
                else {
                    tick1.tick();
                }
                lasting--;
                Thread.Sleep(1000);
            }
        }

      



    }


    
}
