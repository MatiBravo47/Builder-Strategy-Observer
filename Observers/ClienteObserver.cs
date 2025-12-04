using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observers
{
    public class ClienteObserver : IPedidoObserver
    {
        public void OnPedidoConfirmado(Pedido pedido)
        {
            Console.WriteLine($"[Notificacion al Cliente] Gracias {pedido.ClienteNombre}! Tu pedido por {pedido.Total} fue confirmado. Tipo de envio: {pedido.EnvioNombre}");
        }
    }
}
