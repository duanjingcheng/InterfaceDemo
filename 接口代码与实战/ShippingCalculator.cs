using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口代码与实战
{
     class ShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 50)  //如果商品总额不超过50元
            {
                return 10;      //就收10元运费
            }
            return 0;          //否则免运费
        }
    }
}
