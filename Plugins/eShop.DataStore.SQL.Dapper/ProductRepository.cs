using VanThang251_Sales.CoreBusiness.Model;
using VanThang251_Sales.DataStore.HardCodes.Helper;
using VanThang251_Sales.UseCase.PluginInterface.DataStore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanThang251_Sales.DataStore.SQL.Dapper
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDataAccess _dataAccess;

        public ProductRepository(IDataAccess dataAccess)
        {
            this._dataAccess= dataAccess;
        }
        IEnumerable<Product> IProductRepository.GetProduct(string filter)
        {
            List<Product> list;
            if (string.IsNullOrWhiteSpace(filter))
                list = _dataAccess.Query<Product, dynamic>("SELECT * FROM Product", new { });
            else
                list = _dataAccess.Query<Product, dynamic>("SELECT * FROM Product WHERE Name like'%' + @Filter + '%'", new { Filter = filter });
            return list.AsEnumerable();
        }

        Product IProductRepository.GetProductById(int id)
        {
            return _dataAccess.QuerySingle<Product, dynamic>("SELECT * FROM Product WHERE ProductId = @ProductId",
                new { ProductId = id });

        }
    }
}
