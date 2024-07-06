﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanThang251_Sales.Web.CustomerPortal.ViewModels
{
    public class CustomerViewModel
    {
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public string CustomerCity { get; set; }
        [Required]
        public string CustomerStateProvince { get; set; }
        [Required]
        public string CustomerCountry { get; set; }
    }
}
