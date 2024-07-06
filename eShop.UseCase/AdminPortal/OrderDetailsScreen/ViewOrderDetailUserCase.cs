using VanThang251_Sales.CoreBusiness.Model;
using VanThang251_Sales.UseCase.AdminPortal.OrderDetailsScreen.interfaces;
using VanThang251_Sales.UseCase.PluginInterface.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanThang251_Sales.UseCase.AdminPortal.OrderDetailsScreen  
{
    public class ViewOrderDetailUserCase : IViewOrderDetailUserCase
    {
        private readonly IOrderRespository _orderRespository;
        public ViewOrderDetailUserCase(IOrderRespository orderRespository)
        {
            this._orderRespository = orderRespository;
        }
        public Order Execute(int orderId)
        {

            return _orderRespository.GetOrder(orderId);
        }
    }
}
