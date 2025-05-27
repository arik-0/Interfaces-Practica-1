using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Practica_1
{
    public class Usuario 
    {
        private string nombre;
        private string clave;
        private string mail;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Clave { get { return clave; } set { clave = value; } }
        public string Mail { get { return mail; } set { mail = value; } }

    }
}
