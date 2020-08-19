using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Deza.Models.ViewModels
{
    public class ProductVM
    {
        [DisplayName("Product Id")]
        public int ProductId { get; set; }

        [DisplayName("Product Name")]
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        public string ProductName { get; set; }
    }
}
