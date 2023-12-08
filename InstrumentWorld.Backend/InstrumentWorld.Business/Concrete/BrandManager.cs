using System.Collections.Generic;
using System.Threading.Tasks;
using InstrumentWorld.Business.Abstract;
using InstrumentWorld.Business.Utilities.Results;
using InstrumentWorld.DataAccess.Abstract;
using InstrumentWorld.DataAccess.Entities.Concrete;

namespace InstrumentWorld.Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public async Task<Result> AddAsync(Brand entity)
        {
            await _brandDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<Result> DeleteAsync(Brand entity)
        {
            await _brandDal.DeleteAsync(entity);
            return new SuccessResult();
        }

        public async Task<DataResult<Brand>> GetAsync(int id)
        {
            return new SuccessDataResult<Brand>(await _brandDal.GetAsync(x => x.Id == id));
        }

        public async Task<DataResult<List<Brand>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Brand>>(await _brandDal.GetAllAsync());
        }



        public async Task<Result> UpdateAsync(Brand entity)
        {
            await _brandDal.UpdateAsync(entity);
            return new SuccessResult();
        }

    }

}