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
    public interface IOrderServiceAsync
    {
        Task<int> InsertOrderAsync(OrderRequestModel order);
        Task<int> UpdateOrderAsync(OrderRequestModel order,int id);
        Task<int> DeleteOrderAsync(int id);
        Task<OrderResponseModel> GetOrderByIdAsync(int id);
        Task<IEnumerable<OrderResponseModel>> GetAllOrdersAsync();
        Task<IEnumerable<OrderResponseModel>> GetOrdersByCustomerIdAsync(int id);

    }
}
