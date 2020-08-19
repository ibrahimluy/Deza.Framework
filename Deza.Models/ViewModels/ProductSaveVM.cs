using Deza.Stone;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Deza.Models.ViewModels
{
    public class ProductSaveVM
    {
        [DisplayName("Product Id")]
        public int ProductId { get; set; }

        [DisplayName("Product Name")]
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        public string ProductName { get; set; }

        [DisplayName("Category")]
        [Required]
        public int CategoryId { get; set; }

        public List<SelectModel> CategoryList { get; set; }
    }
}
