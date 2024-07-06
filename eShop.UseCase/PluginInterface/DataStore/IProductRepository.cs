﻿using VanThang251_Sales.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanThang251_Sales.UseCase.PluginInterface.DataStore
{
    public interface IProductRepository
    {
        //Trả về danh sách sản phẩm
        IEnumerable<Product> GetProduct(string filter);
        Product GetProductById(int id);

    }
}
