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

            IShippingCalculator doubleEleven=new DoubleElevenShippingCalculator();
            IShippingCalculator putong=new ShippingCalculator();
            var orderProcessor = new OrderProcessor(doubleEleven); //订单处理系统
            if (DateTime.Now != new DateTime(2050, 11, 11))
            {
                orderProcessor = new OrderProcessor(putong);
            }
            orderProcessor.Process(order);
            Console.Read();
            //加个456实验一下git
        }
    }
}
 