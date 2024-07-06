﻿using VanThang251_Sales.CoreBusiness.Model;

namespace VanThang251_Sales.CoreBusiness.Service.Interfaces
{
    public interface IOrderService
    {
        bool ValidateCreateOrder(Order order);
        bool ValidateCustomerInfomation(string name, string address, string city, string provice, string country);
        bool ValidateProcessOrder(Order order);
        bool ValidateUpdateOrder(Order order);
    }
}