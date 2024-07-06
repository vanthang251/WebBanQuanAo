using VanThang251_Sales.CoreBusiness.Model;

namespace VanThang251_Sales.UseCase.ShoppingCartScreen.Interfaces
{
    public interface IViewShoppingCartUserCase
    {
        Task<Order> Execute();
    }
}