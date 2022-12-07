using Microsoft.EntityFrameworkCore;

namespace BackendSocialProject.Models.Data
{
    public class DemoContext : DbContext
    {
        //La idea es que agarre la cadena de conexion y se pueda conectar a la base de datos
        //CTOR para crear constructor
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }

        //Aqui agregamos nuestra entidad modelo, tabla Product  
        public DbSet<Category> Categories { get; set; }

        public DbSet<Plant> Plants { get; set; }
    }
}
