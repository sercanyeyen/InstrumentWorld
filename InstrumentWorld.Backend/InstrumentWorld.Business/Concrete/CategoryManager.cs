using System.Collections.Generic;
using System.Threading.Tasks;
using InstrumentWorld.Business.Abstract;
using InstrumentWorld.Business.Utilities.Results;
using InstrumentWorld.DataAccess.Abstract;
using InstrumentWorld.DataAccess.Entities.Concrete;

namespace InstrumentWorld.Business.Concrete
{
    
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public async Task<Result> AddAsync(Category entity)
        {
            await _categoryDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<Result> DeleteAsync(Category entity)
        {
            await _categoryDal.DeleteAsync(entity);
             return new SuccessResult();
        }

        public async Task<DataResult<Category>> GetAsync(int id)
        {
            return new SuccessDataResult<Category>(await _categoryDal.GetAsync(x=>x.Id==id));
        }

        public async Task<DataResult<List<Category>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Category>>(await _categoryDal.GetAllAsync());
        }

        public async Task<Result> UpdateAsync(Category entity)
        {
            await _categoryDal.UpdateAsync(entity);
             return new SuccessResult();
        }

        
    
    }
}