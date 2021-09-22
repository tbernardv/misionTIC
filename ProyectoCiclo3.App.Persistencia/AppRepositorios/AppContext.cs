using Microsoft.EntityFrameworkCore;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Persistencia
{
    //Genera la conexion con la base de datos
    public class AppContext: DbContext{
        //Si tenemos mas clases como Encomienda, creamos los otros Dbset
        public DbSet<Encomienda> Encomiendas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProyectoCiclo3");
            }
        }
    }
}
