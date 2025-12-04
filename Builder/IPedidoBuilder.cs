using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Strategies;

namespace Builder
{
    public interface IPedidoBuilder
    {
        void Reset();
        void SetCliente(string nombre, string direccion);
        void AddProducto(string nombre, decimal precio, int cantidad);
        void SetEnvio(IEnvioStrategy strategy);
        Pedido Build();
    }
}
