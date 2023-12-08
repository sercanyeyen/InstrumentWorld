using System;
using InstrumentWorld.DataAccess.Entities.BaseEntities;

namespace InstrumentWorld.DataAccess.Entities.Concrete
{
    public class Image:BaseEntity
    {
        public int ProductId { get; set; }
        public DateTime Date{ get; set; }=DateTime.Now;
        public string ImagePath { get; set; }
    }
}