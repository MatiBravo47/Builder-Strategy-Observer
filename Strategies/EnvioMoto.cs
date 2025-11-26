using Models;
using Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategies
{
    public class EnvioMoto : IEnvioStrategy
    {
        public string Nombre => "Moto";

        public decimal CalcularCosto(Pedido pedido)
        {
            //Costo base para envio en moto
            var costoBase = 1500m; //"m" para que sea decimal
            //pedido.Items.Count = cantidad de ítems
            // 200m = costo por ítem
            var variable = 200m * Math.Max(1, pedido.Items.Count); //Se pone "1" para evitar la multiplicacion por 0 
            
            return costoBase + variable;
        }
    }
}
