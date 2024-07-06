using VanThang251_Sales.CoreBusiness.Model;

namespace VanThang251_Sales.UseCase.AdminPortal.OrderDetailsScreen.interfaces
{
    public interface IViewOrderDetailUserCase
    {
        Order Execute(int orderId);
    }
}