using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro2doParcial.Repositories
{
    public interface IRepositorio<T>
    {
        void Guardar(T entidad);
        IEnumerable<T> ObtenerTodos();
    }
}
