using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entity;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class OrderServiceAsync : IOrderServiceAsync
    {
        private readonly IOrderRepositoryAsync _orderRepository;
        private readonly IMapper _mapper;
        public OrderServiceAsync(IOrderRepositoryAsync orderRepo,IMapper mapper)
        {
            _orderRepository = orderRepo;
            _mapper = mapper;
        }
        public async Task<int> DeleteOrderAsync(int id)
        {
            return await _orderRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<OrderResponseModel>> GetAllOrdersAsync()
        {
            return _mapper.Map<IEnumerable<OrderResponseModel>>(await _orderRepository.GetAllAsync());
        }

        public async Task<IEnumerable<OrderResponseModel>> GetOrdersByCustomerIdAsync(int id)
        {
            return _mapper.Map<IEnumerable<OrderResponseModel>>(await _orderRepository.GetByCustomerIdAsync(id));
        }

        public async Task<OrderResponseModel> GetOrderByIdAsync(int id)
        {
            return _mapper.Map<OrderResponseModel>(await _orderRepository.GetByIdAsync(id));
        }

        public async Task<int> InsertOrderAsync(OrderRequestModel model)
        {
            var result = _mapper.Map<Order>(model);
            return await _orderRepository.InsertAsync(result);
        }

        public async Task<int> UpdateOrderAsync(OrderRequestModel order, int id)
        {
            if(id == order.Id)
            {
                var result = _mapper.Map<Order>(order);
                return await _orderRepository.UpdateAsync(result);
            }
            return 0;
        }
    }
}
