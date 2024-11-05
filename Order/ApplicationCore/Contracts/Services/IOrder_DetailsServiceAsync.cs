using ApplicationCore.Entity;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IOrder_DetailsServiceAsync
    {
        Task<int> InsertOrder_DetailsAsync(Order_DetailsRequestModel OrdDetails);
        Task<int> UpdateOrder_DetailsAsync(Order_DetailsRequestModel OrdDetails, int id);
        Task<int> DeleteOrder_DetailsAsync(int id);
        Task<Order_DetailsResponseModel> GetOrder_DetailsByIdAsync(int id);
        Task<IEnumerable<Order_DetailsResponseModel>> GetAllOrders_DetailsAsync();
    }
}
