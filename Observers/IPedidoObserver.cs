using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro2doParcial.Observers
{
    public interface IPedidoObserver
    {
        void OnPedidoConfirmado(Pedido pedido);
    }
}
