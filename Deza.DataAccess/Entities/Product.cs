using Deza.Stone;
using System.ComponentModel.DataAnnotations.Schema;

namespace Deza.DataAccess.Entities
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public string QuantityPerUnit { get; set; }

        public short UnitsInStock { get; set; }

        public decimal UnitPrice { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
