using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Update
    {

        public static void Main(string[] args) {
            GenericList<int> intList = new GenericList<int>();
            for (int x = 0; x < 10; x++) {
                intList.Add(x);
            
            }
            for (Node<int> node = intList.Head; node != null; node = node.Next) {
                Console.WriteLine(node.Data);
            }
            GenericList<string> strList = new GenericList<string>();
            for (int x = 0; x < 10; x++)
            {
                strList.Add("str"+x);

            }
            for (Node<string> node = strList.Head; node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }
            GenericList<float> floatList = new GenericList<float>();
            for (int x = 0; x < 10; x++)
            {
                floatList.Add(x);

            }
            for (Node<float> node = floatList.Head; node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }

            //
            Action<float> action1 = GenericList<float>.printf;
            floatList.ForEach(action1);
           action1 = GenericList<float>.getMax;
            floatList.ForEach(action1);
            Console.WriteLine(GenericList<float>.max);
            action1 = GenericList<float>.getMin;
            floatList.ForEach(action1);
            Console.WriteLine(GenericList<float>.min);
            action1 = GenericList<float>.getTotal;
            floatList.ForEach(action1);
            Console.WriteLine(GenericList<float>.total);
            while (true) ;
        
        }
    }
}
