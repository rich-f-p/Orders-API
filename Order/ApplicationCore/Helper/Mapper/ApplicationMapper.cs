using ApplicationCore.Entity;
using ApplicationCore.Model.Request;
using ApplicationCore.Model.Response;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Helper.Mapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Order, OrderRequestModel>().ReverseMap();
            CreateMap<Order, OrderResponseModel>().ReverseMap();
        }
    }
}
