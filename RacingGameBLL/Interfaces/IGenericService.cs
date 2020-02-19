using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RacingGameBLL.Interfaces
{
    public interface IGenericService<DALModel> where DALModel:class
    {
        Task<IEnumerable<DALModel>> GetAllAsync();
        Task<DALModel> GetByIdAsync(int id);
    }
}
