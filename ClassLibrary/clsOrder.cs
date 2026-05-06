using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool IsDispatched { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNo { get; set; }
        public int CustomerNo { get; set; }
        public double TotalAmount { get; set; }
        public string DeliveryAddress { get; set; }
    }
}