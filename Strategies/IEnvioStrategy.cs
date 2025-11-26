using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Strategies
{
    public interface IEnvioStrategy
    {
        string Nombre { get; }
        decimal CalcularCosto(Pedido pedido);
    }
}
