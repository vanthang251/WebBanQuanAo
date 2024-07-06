namespace VanThang251_Sales.UseCase.AdminPortal.OrderDetailsScreen.interfaces
{
    public interface IProcessOrderUseCase
    {
        bool Execute(int orderId, string adminUserName);
    }
}