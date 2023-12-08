using InstrumentWorld.DataAccess.Abstract;
using InstrumentWorld.DataAccess.Entities.Concrete;
using InstrumentWorld.DataAccess.Repositories;

namespace InstrumentWorld.DataAccess.Concrete
{
    public class ImageDal : EntityRepositoryDal<Image, EdDBContext>, IImageDal { }
}