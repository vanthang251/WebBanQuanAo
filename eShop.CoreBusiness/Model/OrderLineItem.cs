﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanThang251_Sales.CoreBusiness.Model
{
    public class OrderLineItem
    {
        public int? LineItemId { get; set; }
        public int ProductId {  get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int? OrderId { get; set; }  
        public Product Product { get; set; }
    }
}
