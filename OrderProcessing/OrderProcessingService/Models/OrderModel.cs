using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingService.Models
{
    public class OrderModel
    {
        public int OrderId { get;set;}
        public string CustomerName { get;set;}
        public string ProductName { get;set;}
        public int Quantity { get;set; }
        public decimal Price { get;set; }
        public DateTime OrderDate { get;set; }
        public string Status { get;set; }        
    }
}