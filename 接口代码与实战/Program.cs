using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口代码与实战
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order 
            {
                Id = 123,
                DatePlaced = DateTime.Now,
                TotalPrice = 100f
            };
            var orderProcessor = new OrderProcessor(); //订单处理系统
            orderProcessor.Process(order);
            Console.Read();
        }
    }
}
