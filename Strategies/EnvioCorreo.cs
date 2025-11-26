using Models;
using Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategies
{
    public class EnvioCorreo : IEnvioStrategy
    {
        public string Nombre => "Correo";

        public decimal CalcularCosto(Pedido pedido)
        {
            var costo = Math.Max(2500m, pedido.Items.Sum(i => i.Total) * 0.06m);
            return decimal.Round(costo, 2);
        }
    }
}
