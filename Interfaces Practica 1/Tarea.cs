using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Practica_1
{
    public class Tarea
    {
        public Tarea() 
        {
            listaUsuarios = new List<Usuario>();
            estado = Estado.Iniciado;
        }

        private string descripcion;
        private Estado estado;
        private Prioridad prioridad;
        private List<Usuario> listaUsuarios;
        
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public Estado Estado { get; set; }
        public Prioridad Prioridad { get; set; }
    }

    public enum Estado
    {
        Iniciado,
        Completado,
        Vencido
    }

    public enum Prioridad
    {
        Baja,
        Media,
        Alta
    }
}
