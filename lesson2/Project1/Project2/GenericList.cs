using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
 
    public class GenericList<T> {

        public static float max = float.MaxValue*(-1);
       public static float min=float.MaxValue;
      public  static float total=0;
        private Node<T> head;
        private Node<T> tail;
        public GenericList() { 
            tail=head=null;
    }
        public Node<T> Head{
            get { return head; }
        }

        public void ForEach(Action<T> action) {

            for (Node<T> node = head; node != null; node = node.Next)
            {
                action(node.Data);
            }
        
        }

        public static void printf(T t )
        {

            Console.WriteLine(t);
        }

        public static void getMax(float t) {
            
            if (max<t) {
                max = t;

            }
        
        }
        public static void getMin(float t)
        {

            if (min > t)
            {
                min = t;


            }

        }
        public static void getTotal(float t)
        {

            total += t;
        }

        public void Add(T t){
        Node<T> n =new Node<T>(t);
            if(tail==null){
                head=tail=n;
            }else{
                tail.Next=n;
                tail=n;
            }
        
        }

    }
  
}
