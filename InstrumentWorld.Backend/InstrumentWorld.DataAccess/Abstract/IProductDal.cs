using System;
using InstrumentWorld.DataAccess.Entities.Concrete;
using InstrumentWorld.DataAccess.Repositories;
using InstrumentWorld.DataAccess.Entities.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;


namespace InstrumentWorld.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepositoryDal<Product>
    {
        Task<List<ProductDto>> GetProductDetailsAsync(Expression<Func<ProductDto,bool>> filter=null);

    }
}