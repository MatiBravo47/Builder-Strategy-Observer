using Models;
using Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategies
{
    public class EnvioRetiro : IEnvioStrategy
    {
        public string Nombre => "Retiro en local";

        public decimal CalcularCosto(Pedido pedido)
        {
            return 0m;
        }
    }
}
