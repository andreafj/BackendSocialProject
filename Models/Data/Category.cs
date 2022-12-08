using System.ComponentModel.DataAnnotations;

namespace BackendSocialProject.Models.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool State { get; set; }
        public IEnumerable<Plant>? Plants { get; set;}
    }
}
