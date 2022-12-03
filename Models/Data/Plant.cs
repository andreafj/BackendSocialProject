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
        public string Description { get; set; }
    }
}
