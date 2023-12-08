using System;
using System.Collections.Generic;
using InstrumentWorld.DataAccess.Entities.BaseEntities;

namespace InstrumentWorld.DataAccess.Entities.Concrete
{
    public class Product:BaseEntity
    {
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ChildCategoryId { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
    }
        
}