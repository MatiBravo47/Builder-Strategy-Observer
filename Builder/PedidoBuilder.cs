using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategies;

namespace Simulacro2doParcial.Builder
{
    public class PedidoBuilder : IPedidoBuilder
    {
        private Pedido _pedido = new();
        private IEnvioStrategy? _envio;

        public void Reset() 
        {
            //Crea un nuevo pedido vacío:
            _pedido = new Pedido();
            //Borra la estrategia de envío:
            _envio = null;

        }
        public void SetCliente(string nombre, string direccion)
        {
            //.Trim(): elimina los espacios en blanco del inicio y del final del texto
            _pedido.ClienteNombre = nombre.Trim();
            _pedido.Direccion = direccion.Trim();
        }
        public void AddProducto(string nombre, decimal precio, int cantidad) 
        {
            _pedido.Items.Add(new Producto { Nombre = nombre.Trim(), Precio = precio, Cantidad = cantidad });
        }
        public void SetEnvio(IEnvioStrategy strategy) 
        {
            _envio = strategy;
            _pedido.EnvioNombre = strategy.Nombre;
        }
        
        public Pedido Build()
        {
            if (_pedido.Items.Count == 0) throw new InvalidOperationException("El pedido no tiene productos");
            if (string.IsNullOrWhiteSpace(_pedido.ClienteNombre)) throw new InvalidOperationException("Falta el nombre del cliente");
            if (string.IsNullOrWhiteSpace(_pedido.Direccion)) throw new InvalidOperationException("Falta la direccion del cliente");
            if (_envio is null) throw new InvalidOperationException("No se selecciono el envio");

            return _pedido;

        }
    }
}
