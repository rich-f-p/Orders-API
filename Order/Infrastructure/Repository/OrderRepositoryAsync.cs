using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entity;
using ApplicationCore.Model.Response;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class OrderRepositoryAsync : BaseRepositoryAsync<Order> , IOrderRepositoryAsync
    {
        private readonly OrderDbContext context;

        public OrderRepositoryAsync(OrderDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<OrderResponseModel>> GetByCustomerIdAsync(int id)
        {
            var result = await context.Orders.Where(o => o.CustomerId == id).ToListAsync();
            return (IEnumerable<OrderResponseModel>)result;
        }
    }
}
