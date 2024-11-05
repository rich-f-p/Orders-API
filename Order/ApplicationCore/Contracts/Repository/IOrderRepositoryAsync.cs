using ApplicationCore.Entity;
using ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repository
{
    public interface IOrderRepositoryAsync : IRepositoryAsync<Order>
    {
        Task<IEnumerable<OrderResponseModel>> GetByCustomerIdAsync(int id);
    }
}
