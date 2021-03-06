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
                new Usuario{id=1,nombre="Tyson",apellidos="Bernard Villada",direccion="Calle 30",telefono="3004966288",ciudad="San Andrés Islas"},
                new Usuario{id=2,nombre="Vanessa",apellidos="Prieto",direccion="Belén Málibu",telefono="300xxxxxxx",ciudad="Medellín"}
 
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return usuarios;
        }
 
        public Usuario GetUsuarioWithId(int id){
            return usuarios.SingleOrDefault(b => b.id == id);
        }

        public Usuario Create(Usuario newUsuario)
        {
            if(usuarios.Count > 0){
                newUsuario.id=usuarios.Max(r => r.id) +1; 
            }else{
               newUsuario.id = 1; 
            }
            usuarios.Add(newUsuario);
            return newUsuario;
        }

        public Usuario Update(Usuario newUsuario){
            var usuario= usuarios.SingleOrDefault(b => b.id == newUsuario.id);
            if(usuario != null){
                usuario.nombre = newUsuario.nombre;
                usuario.apellidos = newUsuario.apellidos;
                usuario.direccion = newUsuario.direccion;
                usuario.telefono = newUsuario.telefono;
                usuario.ciudad = newUsuario.ciudad;
            }
            return usuario;
        }

        public Usuario Delete(int id)
        {
            var usuario= usuarios.SingleOrDefault(b => b.id == id);
            usuarios.Remove(usuario);
            return usuario;
        }


    }
}
