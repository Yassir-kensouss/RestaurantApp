using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Model
{
    public class Category
    {
        [Key] // Primary key
        public int Id { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        [MaxLength(100, ErrorMessage = "Category name has to be 100 char or less")]
        [Display(Name = "Category_Name")]
        public string? Name { get; set; }


        [Display(Name = "Display Order")]
        [Required(ErrorMessage = "Display order is required")]
        [Range(1,200, ErrorMessage = "Display order must be between 1 and 200")]
        public int DisplayOrder { get; set; }
    }
}
