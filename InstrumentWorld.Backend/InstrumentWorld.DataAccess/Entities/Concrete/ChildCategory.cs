using InstrumentWorld.DataAccess.Entities.BaseEntities;

namespace InstrumentWorld.DataAccess.Entities.Concrete
{
    public class ChildCategory:BaseEntity
    {
        public int CategoryId { get; set; }
        public string ChildCategoryName { get; set; }
    }
}