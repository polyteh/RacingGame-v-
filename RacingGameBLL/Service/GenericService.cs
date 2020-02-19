using AutoMapper;
using RacingGameBLL.Interfaces;
using RacingGameDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RacingGameBLL.Service
{
    public abstract class GenericService<BLLModel, DALModel> : IGenericService<BLLModel>
        where BLLModel : class
        where DALModel : class, IEntity, IName
    {
        protected IMapper _mapper;
        protected readonly IGenericRepository<DALModel> _repository;
        public GenericService(IGenericRepository<DALModel> rep)
        {
            _repository = rep;
        }

        public async Task<IEnumerable<BLLModel>> GetAllAsync()
        {
            var listOfDAL = await _repository.GetAllAsync();
            return Map(listOfDAL);
        }

        public Task<BLLModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public abstract IEnumerable<BLLModel> Map(IEnumerable<DALModel> dalModels);
    }
}
