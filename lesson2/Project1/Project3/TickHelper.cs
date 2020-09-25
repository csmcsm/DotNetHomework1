using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
   public  class TickHelper
    {
       public delegate void tickHandler(object sender, tickEventArgs args);
           public class tickEventArgs{
           public int lasting{get;set;}
           }
       public event tickHandler ontick;
        public void ForEach(Action action)
        {
                action();
        }
        public  void tick() {

            tickEventArgs args = new tickEventArgs();
      
            ontick(this,args);

        }
        public static void ticking(object sender, tickEventArgs args) {

            Console.WriteLine("tick");
        
        }
        public static void alarming(object sender, tickEventArgs args)
        {

            Console.WriteLine("alarm");

        }
        public static void alarm()
        {

            Console.WriteLine("alarm");

        }
      
    }
}
