using VanThang251_Sales.CoreBusiness.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanThang251_Sales.UseCase.ViewProductScreen.Interfaces
{
    public interface IViewProductUseCase
    {
        Product Execute(int id);
    }
}
