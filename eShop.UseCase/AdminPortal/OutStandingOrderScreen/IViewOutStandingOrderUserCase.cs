using VanThang251_Sales.CoreBusiness.Model;

namespace VanThang251_Sales.UseCase.AdminPortal.OutStandingOrderScreen
{
    public interface IViewOutStandingOrderUserCase
    {
        IEnumerable<Order> Execute();
    }
}