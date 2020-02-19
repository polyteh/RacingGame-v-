using AutoMapper;
using RacingGameBLL.Interfaces;
using RacingGameBLL.Models;
using RacingGameDAL.Interfaces;
using RacingGameDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RacingGameBLL.Service
{
    public class ManufacturerService: GenericService<ManufacturerBLL, Manufacturer>, IManufacturerService
    {
        public ManufacturerService(IGenericRepository<Manufacturer> rep, IMapper mapper):base(rep)
        {
            _mapper = mapper;
        }

        public override IEnumerable<ManufacturerBLL> Map(IEnumerable<Manufacturer> dalModels)
        {
            return _mapper.Map<IEnumerable<ManufacturerBLL>>(dalModels);
        }
    }
}
