using VanThang251_Sales.CoreBusiness.Model;

namespace VanThang251_Sales.UseCase.AdminPortal.ProcessedOrderScreen
{
    public interface IViewPrcessedOrderUserCase
    {
        IEnumerable<Order> Execute();
    }
}