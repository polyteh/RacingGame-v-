using AutoMapper;
using RacingGameBLL.Models;
using RacingGameDAL.Models;
using RacingWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RacingWebApi.Config
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Manufacturer, ManufacturerBLL>().ReverseMap();
            CreateMap<ManufacturerView, ManufacturerBLL>().ReverseMap();
        }
    }
}
