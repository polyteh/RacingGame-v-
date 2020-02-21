using AutoMapper;
using RacingGameBLL.Interfaces;
using RacingGameBLL.Models;
using RacingGameDAL.Interfaces;
using RacingGameDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public override ManufacturerBLL Map(Manufacturer dalModels)
        {
            return _mapper.Map<ManufacturerBLL>(dalModels);
        }

        public override Manufacturer Map(ManufacturerBLL bllModel)
        {
            return _mapper.Map<Manufacturer>(bllModel);
        }
    }

}
