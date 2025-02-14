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
        private readonly DoubleElevenShippingCalculator _doubleElevenShippingCalculator;
        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();  //计算订单运费
            _doubleElevenShippingCalculator = new DoubleElevenShippingCalculator(); 
        }

        public void Process(Order order)  
        {
            if (order.IsShipped)   //判断订单是否已经被处理
                throw new InvalidOperationException("订单已发货");

            DateTime doubleEleven = new DateTime(2022, 11, 11);

            order.Shipment = new Shipment  //给订单创建一个发货信息 
            {  
                //判断日期是否是双十一，从而决定是否要免运费。
                Cost =DateTime.Now==doubleEleven?
                _doubleElevenShippingCalculator.CalculateShipping(order):
                _shippingCalculator.CalculateShipping(order),

                ShippingDate = DateTime.Today.AddDays(1)
            };
            
            order.IsShipped = true;  // 设置订单状态为已发货
            
            Console.WriteLine($"订单#{order.Id}完成，已发货");
        }
    }
}
