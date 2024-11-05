using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entity;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class Order_DetailsRepositoryAsync : BaseRepositoryAsync<Order_Details>, IOrder_DetailsRepositoryAsync
    {
        public Order_DetailsRepositoryAsync(OrderDbContext context) : base(context)
        {
        }
    }
}
