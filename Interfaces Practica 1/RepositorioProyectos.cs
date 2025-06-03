using System;
using System.Collections.Generic;
using System.Linq;

namespace Interfaces_Practica_1
{
    public class RepositorioProyectos : IRepositorios<Proyecto>
    {
        private readonly List<Proyecto> listaProyectos;

        public RepositorioProyectos()
        {
            listaProyectos = new List<Proyecto>();
        }

        public string Agregar(Proyecto unProyecto)
        {
            if (listaProyectos.Any(p => p.Nombre.Equals(unProyecto.Nombre, StringComparison.OrdinalIgnoreCase)))
            {
                return "El proyecto ya existe.";
            }

            listaProyectos.Add(unProyecto);
            return "Proyecto agregado correctamente.";
        }

        public string Modificar(Proyecto unProyecto)
        {
            var index = listaProyectos.FindIndex(p => p.Nombre.Equals(unProyecto.Nombre, StringComparison.OrdinalIgnoreCase));
            if (index == -1)
            {
                return "Proyecto no encontrado.";
            }

            listaProyectos[index] = unProyecto;
            return "Proyecto modificado correctamente.";
        }

        public string Eliminar(Proyecto unProyecto)
        {
            var proyecto = listaProyectos.FirstOrDefault(p => p.Nombre.Equals(unProyecto.Nombre, StringComparison.OrdinalIgnoreCase));
            if (proyecto == null)
            {
                return "Proyecto no encontrado.";
            }

            listaProyectos.Remove(proyecto);
            return "Proyecto eliminado correctamente.";
        }

        public IReadOnlyCollection<Proyecto> Listar()
        {
            return listaProyectos.AsReadOnly();
        }

    }
}
