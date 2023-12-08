using System.Collections.Generic;
using System.Threading.Tasks;
using InstrumentWorld.Business.Utilities;
using InstrumentWorld.Business.Utilities.Results;
using InstrumentWorld.DataAccess.Entities.Concrete;

namespace InstrumentWorld.Business.Abstract
{
    public interface IChildCategoryService:IServiceRepository<ChildCategory>
    {
        Task<DataResult<ChildCategory>> GetAsync(int id);
        Task<DataResult<List<ChildCategory>>> GetByCategoryIdAsync(int categoryId);
        
    } 

}