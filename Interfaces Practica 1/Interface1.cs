using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Practica_1
{
    public interface IRepositorios<T>
    {
        string Agregar(T objeto);
        string Modificar(T objeto);
        string Eliminar(T objeto);
        IReadOnlyCollection<T> Listar();
    }
}
