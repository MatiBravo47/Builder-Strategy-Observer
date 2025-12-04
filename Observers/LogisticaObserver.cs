using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observers
{
    public class LogisticaObserver : IPedidoObserver
    {
        public void OnPedidoConfirmado(Pedido pedido)
        {
            Console.WriteLine("[Logistica] Nuevo pedido confirmado. Preparar packing list:");
            foreach (var it in pedido.Items)
                Console.WriteLine($" {it.Cantidad} x {it.Nombre} {it.Precio} c/u ");
            Console.WriteLine($"Envio: {pedido.EnvioNombre} Total: ${pedido.Total}");
        }
    }
}
