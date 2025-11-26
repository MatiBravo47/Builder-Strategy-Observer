using Simulacro2doParcial.Builder;
using Simulacro2doParcial.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Simulacro2doParcial.Services
{
    public class PedidoService
    {
        private readonly List<IPedidoObserver> _observers = new();

        public void Suscribir(IPedidoObserver observer) => _observers.Add(observer);
        public void Desuscribir(IPedidoObserver observer) => _observers.Remove(observer);

        public void Confirmar(Pedido pedido) 
        {
            Notificar(pedido);
        }

        private void Notificar(Pedido pedido)
        {
            foreach (var obs in _observers)
            {
                try { obs.OnPedidoConfirmado(pedido);  }
                catch 
                {
                    Console.WriteLine("No se pudo notificar!"); 
                }
            }
        }
    }
}
