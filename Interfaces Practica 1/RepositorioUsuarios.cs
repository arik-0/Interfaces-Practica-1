using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Practica_1
{
    public class RepositorioUsuarios : IRepositorios<Usuario>
    {
        private List<Usuario> listaUsuarios;
        public RepositorioUsuarios()
        {
            listaUsuarios = new List<Usuario>();

        }
        

        public string Agregar(Usuario unUsuario) //Si no existe agrega la tarea
        {
            var estaAgregada = listaUsuarios.FirstOrDefault(x => x == unUsuario);
            if (estaAgregada == null)
            {
                listaUsuarios.Add(unUsuario);
            }
            else { MessageBox.Show("Ya existe papu"); }

            return"";
        }
        public string Modificar(Usuario unUsuario)
        {
            var index = listaUsuarios.FindIndex(x => x.Nombre == unUsuario.Nombre);
            if (index != -1)
            {
                listaUsuarios[index] = unUsuario;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
            return"";
        }

        public string Eliminar(Usuario unUsuario)
        {
            var usuario = listaUsuarios.FirstOrDefault(x => x.Nombre == unUsuario.Nombre);
            if (usuario != null)
            {
                listaUsuarios.Remove(usuario);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
            return"";
        }
        public IReadOnlyCollection<Usuario> Listar()
        {
            return listaUsuarios.AsReadOnly();
        }
    }
}
