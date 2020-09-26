using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            os.orders = null;
            os.Export();
            Console.WriteLine("Hello World!");
        }
    }
}
