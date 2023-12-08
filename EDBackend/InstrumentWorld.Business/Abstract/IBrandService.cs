using System.Collections.Generic;
using System.Threading.Tasks;
using InstrumentWorld.Business.Utilities;
using InstrumentWorld.Business.Utilities.Results;
using InstrumentWorld.DataAccess.Entities.Concrete;

namespace InstrumentWorld.Business.Abstract
{
    public interface IBrandService:IServiceRepository<Brand>
    {
        Task<DataResult<Brand>> GetAsync(int id);
       
        
    }
}