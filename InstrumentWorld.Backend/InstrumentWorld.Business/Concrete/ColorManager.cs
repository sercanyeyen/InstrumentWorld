using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstrumentWorld.Business.Abstract;
using InstrumentWorld.Business.Utilities.Results;
using InstrumentWorld.DataAccess.Abstract;
using InstrumentWorld.DataAccess.Entities.Concrete;

namespace InstrumentWorld.Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal=colorDal;  
        }

        public async Task<Result> AddAsync(Color entity)
        {
            await _colorDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<Result> DeleteAsync(Color entity)
        {
            await _colorDal.DeleteAsync(entity);
            return new SuccessResult();
        }

        public async Task<DataResult<Color>> GetAsync(int id)
        {
            return new SuccessDataResult<Color>(await _colorDal.GetAsync(x=>x.Id==id));
        }

        public async Task<DataResult<List<Color>>> GetAllAsync()
        {
            return new SuccessDataResult<List<Color>>(await _colorDal.GetAllAsync());
        }

        public async Task<Result> UpdateAsync(Color entity)
        {
            await _colorDal.UpdateAsync(entity);
            return new SuccessResult();
        }
    }
}
