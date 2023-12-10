using System.ComponentModel.DataAnnotations;

namespace BulkyBooks2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }
        [Range(1,100, ErrorMessage ="YOU STUPID NIGGER")]
        public int DisplayOrder { get; set; }
    }
}
