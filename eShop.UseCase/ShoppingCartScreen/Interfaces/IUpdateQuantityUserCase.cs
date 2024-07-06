using VanThang251_Sales.CoreBusiness.Model;

namespace VanThang251_Sales.UseCase.ShoppingCartScreen.Interfaces
{
    public interface IUpdateQuantityUserCase
    {
        Task<Order> Execute(int productId, int quatity);
    }
}