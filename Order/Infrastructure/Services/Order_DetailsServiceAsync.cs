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
    public class Order_DetailsServiceAsync : IOrder_DetailsServiceAsync
    {
        private readonly IOrder_DetailsRepositoryAsync _repository;
        private readonly IMapper _mapper;
        public Order_DetailsServiceAsync(IMapper map, IOrder_DetailsRepositoryAsync repo)
        {
            _mapper = map;
            _repository = repo;
        }
        public async Task<int> DeleteOrder_DetailsAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Order_DetailsResponseModel>> GetAllOrders_DetailsAsync()
        {
            return _mapper.Map<IEnumerable<Order_DetailsResponseModel>>(await _repository.GetAllAsync()); 
        }

        public async Task<Order_DetailsResponseModel> GetOrder_DetailsByIdAsync(int id)
        {
            return _mapper.Map<Order_DetailsResponseModel>(await _repository.GetByIdAsync(id));
        }

        public async Task<int> InsertOrder_DetailsAsync(Order_DetailsRequestModel OrdDetails)
        {
            var result = _mapper.Map<Order_Details>(OrdDetails);
            return await _repository.InsertAsync(result);
        }

        public async Task<int> UpdateOrder_DetailsAsync(Order_DetailsRequestModel OrdDetails, int id)
        {
            if(id == OrdDetails.Id)
            {
                var result = _mapper.Map<Order_Details>(OrdDetails);
                return await _repository.UpdateAsync(result);
            }
            return 0;
        }
    }
}
