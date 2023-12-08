using System.Collections.Generic;
using System.Threading.Tasks;
using InstrumentWorld.Business.Utilities;
using InstrumentWorld.Business.Utilities.Results;
using InstrumentWorld.DataAccess.Entities.Concrete;
using InstrumentWorld.DataAccess.Entities.Dtos;

namespace InstrumentWorld.Business.Abstract
{
    public interface IProductService : IServiceRepository<Product>
    {
        Task<DataResult<Product>> GetByProductIdAsync(int id);
                
        Task<DataResult<List<Product>>> GetByCategoryIdAsync(int id);
        Task<DataResult<List<Product>>> GetByChildCategoryIdAsync(int id);
        Task<DataResult<List<Product>>> GetByColorIdAsync(int id);
        Task<DataResult<List<Product>>> GetByBrandIdAsync(int id);

        Task<DataResult<List<ProductDto>>> GetProductDtoAsync();
        Task<DataResult<List<ProductDto>>> GetProductDtoByIdAsync(int id);

      
    }
}