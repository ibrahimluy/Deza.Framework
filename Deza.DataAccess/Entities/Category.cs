using Deza.Stone;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Deza.DataAccess.Entities
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }

        [StringLength(200)]
        [Required]
        public string CategoryName { get; set; }

        [Column(TypeName = "SmallDateTime")]
        public DateTime CreatedDate { get; set; }
    }
}
