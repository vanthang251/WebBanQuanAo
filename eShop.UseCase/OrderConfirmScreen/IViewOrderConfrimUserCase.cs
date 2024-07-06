using VanThang251_Sales.CoreBusiness.Model;

namespace VanThang251_Sales.UseCase.OrderConfirmScreen
{
    public interface IViewOrderConfrimUserCase
    {
        Order Execute(string uniqueId);
    }
}