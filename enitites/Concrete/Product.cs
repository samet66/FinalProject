using enities.Abstract;
using System;

namespace enities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public short UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
