using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口代码与实战
{
   public  interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
}
