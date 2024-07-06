using VanThang251_Sales.CoreBusiness.Model;
using VanThang251_Sales.UseCase.PluginInterface.StateStore;
using VanThang251_Sales.UseCase.PluginInterface.UI;
using VanThang251_Sales.UseCase.ShoppingCartScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanThang251_Sales.UseCase.ShoppingCartScreen
{

    public class DeleteProductUserCase : IDeleteProductUserCase
    {
        private readonly IShopingCart _shoppingcart;
        private readonly IShoppingCartStateStore _shoppingCartStateStore;
        public DeleteProductUserCase(IShopingCart shopingCart, IShoppingCartStateStore shoppingCartStateStore)
        {

            this._shoppingcart = shopingCart;
            this._shoppingCartStateStore = shoppingCartStateStore;
        }
        public async Task<Order> Execute(int productId)
        {
            var order = await this._shoppingcart.DeleteProductAsync(productId);
            this._shoppingCartStateStore.UpdateLineItemsCount();
            return order;
        }
    }
}
