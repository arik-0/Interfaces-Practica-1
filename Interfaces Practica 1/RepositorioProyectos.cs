using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Practica_1
{
    public class RepositorioProyectos : IRepositorios<Usuario>
    {
        private List<Usuario> listaProyectos;
        public RepositorioProyectos()
        {
            listaProyectos = new List<Usuario>();
        }


        public string Agregar(Usuario unUsuario) //Si no existe agrega la tarea
        {
            var estaAgregada = listaProyectos.FirstOrDefault(x => x == unUsuario);
            if (estaAgregada == null)
            {
                listaProyectos.Add(unUsuario);
            }
            else { MessageBox.Show("Ya existe papu"); }

            return "";
        }
        public string Modificar(Usuario unUsuario)
        {
            var index = listaProyectos.FindIndex(x => x.Nombre == unUsuario.Nombre);
            if (index != -1)
            {
                listaProyectos[index] = unUsuario;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
            return "";
        }

        public string Eliminar(Usuario unUsuario)
        {
            var usuario = listaProyectos.FirstOrDefault(x => x.Nombre == unUsuario.Nombre);
            if (usuario != null)
            {
                listaProyectos.Remove(usuario);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
            return "";
        }
        public IReadOnlyCollection<Usuario> Listar()
        {
            return listaProyectos.AsReadOnly();
        }
    }
}
