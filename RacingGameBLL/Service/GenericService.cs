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

        public async Task<BLLModel> GetByIdAsync(int id)
        {
            var itemByIdDAL = await _repository.GetByIdAsync(id);
            return Map(itemByIdDAL);
        }

        public abstract IEnumerable<BLLModel> Map(IEnumerable<DALModel> dalModels);
        public abstract BLLModel Map(DALModel dalModel);
        public abstract DALModel Map(BLLModel bllModel);

        public async Task<bool> AddAsync(BLLModel entity)
        {
            var entityDAL = Map(entity);
            bool isItemAdded = await _repository.AddAsync(entityDAL);
            return isItemAdded;
        }
    }
}
