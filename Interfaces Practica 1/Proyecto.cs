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
            fechaInicio = DateTime.Now;
            listaTareas = new List<Tarea>();
        }
        private string nombre;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private List<Tarea> listaTareas;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public DateTime FechaInicio { get { return fechaInicio; } }
        public DateTime FechaFin { get { return fechaFin; } set {fechaFin = value; } }
        public List<Tarea> ListaTareas { get; }

        public void AgregarTarea(Tarea tarea) //Si no existe agrega la tarea
        {
            var estaAgregada = listaTareas.FirstOrDefault(x => x == tarea);
            if (estaAgregada == null)
            {
                listaTareas.Add(tarea);
            }
            else { MessageBox.Show("Ya existe papu"); }

            return;
        }
    }

}
