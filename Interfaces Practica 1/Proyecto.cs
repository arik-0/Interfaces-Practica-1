using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Practica_1
{
    public class Proyecto
    {
        public Proyecto()
        {
           // listaTareas = new List<Tarea>();
        }

        private string nombre;
        private DateTime fechaInicio;
        private DateTime fechaFin;
       // private List<Tarea> listaTareas;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public DateTime FechaInicio => fechaInicio;

        public DateTime FechaFin
        {
            get => fechaFin;
            set => fechaFin = value;
        }

       /* public List<Tarea> ListaTareas => listaTareas;

        // Agrega una tarea si no existe una con la misma descripción
        public bool AgregarTarea(Tarea tarea)
        {
            if (listaTareas.Any(t => t.Descripcion == tarea.Descripcion))
            {
                // Ya existe tarea con esa descripción
                return false;
            }
            listaTareas.Add(tarea);
            return true;
        }*/

        // Puedes agregar métodos ModificarTarea, EliminarTarea según necesites
    }

}
