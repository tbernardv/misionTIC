using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuario
    {
        List<Usuario> usuarios;
 
        public RepositorioUsuario()
        {
            usuarios= new List<Usuario>()
            {
                new Usuario{id=1,nombre="Tyson",apellidos="Bernard Villada",direccion="Calle 30",telefono="3004966288"},
                new Usuario{id=2,nombre="Vanessa",apellidos="Prieto",direccion="Belén Málibu",telefono="300xxxxxxx"}
 
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetUsuarioWithId(int id){
            return usuarios.SingleOrDefault(b => b.id == id);
        }
    }
}
