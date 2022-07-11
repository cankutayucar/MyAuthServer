using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CankutayUcarAuthServer.Core.Dtos;
using CankutayUcarAuthServer.Core.Models;

namespace CankutayUcarAuthServer.Service.Mappers
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}
