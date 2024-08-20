using System.ComponentModel.DataAnnotations;

namespace Demo_App.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

    }
}
