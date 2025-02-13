using System;

namespace 接口代码与实战
{
    // 添加 Order 类的定义
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        public bool IsShipped { get; set; }  // 添加发货状态属性
        public Shipment Shipment { get; set; }  // 添加发货信息属性
    }
}
