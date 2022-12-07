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
        public string Name { get; set; }
        public string Genus { get; set; }
        public string ScientificName { get; set; }
        public string commonName { get; set; }
        public string Description { get; set; }
        //Foreing key
        public int CategoryID { get; set; }
        public Category category { get; set; }
    }
}
