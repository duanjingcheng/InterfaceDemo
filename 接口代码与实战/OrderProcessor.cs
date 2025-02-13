using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口代码与实战
{
     class OrderProcessor
    {
        private readonly ShippingCalculator  _shippingCalculator;
        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();  //计算订单运费
        }

        public void Process(Order order)  
        {
            if (order.IsShipped)   //判断订单是否已经被处理
                throw new InvalidOperationException("订单已发货");

            order.Shipment = new Shipment  //给订单创建一个发货信息 
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
            
            order.IsShipped = true;  // 设置订单状态为已发货
            
            Console.WriteLine($"订单#{order.Id}完成，已发货");
        }
    }
}
