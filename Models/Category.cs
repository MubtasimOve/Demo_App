using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Demo_App.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }

    }
}
