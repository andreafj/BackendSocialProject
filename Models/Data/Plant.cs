using System.ComponentModel.DataAnnotations;

namespace BackendSocialProject.Models.Data
{
    public class Plant
    {
        [Key]       
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //Control +. para importar 
        public int Id { get; set; }
        //shortcut 'prop' para propiedades
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genus { get; set; }
        [Required]
        public string ScientificName { get; set; }
        [Required]
        public string commonName { get; set; }  
        [Required]
        public string Description { get; set; }
        //Foreing key
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
