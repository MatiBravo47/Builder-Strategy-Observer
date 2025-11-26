using Services;
using Simulacro2doParcial.Builder;
using Simulacro2doParcial.Repositories;
using Simulacro2doParcial.Services;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro2doParcial.Controllers
{
    public class CheckoutFacade
    {
        private readonly IPedidoBuilder _builder;
        private readonly StrategyFactory _factory;
        private readonly PedidoService _service;
        private readonly IRepositorio<Pedido> _repo;

        public CheckoutFacade(IPedidoBuilder builder, StrategyFactory factory, PedidoService service, IRepositorio<Pedido> repo)
        {
            _builder = builder;
            _factory = factory;
            _repo = repo;
            _service = service;
            _builder.Reset();
        }

        public void Reset() => _builder.Reset();

        public void SetDatosCliente(string nombre, string direccion)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("El nombre es obligatorio");
            if (string.IsNullOrWhiteSpace(direccion)) throw new ArgumentException("La direccion es obligatoria");
            _builder.SetCliente(nombre, direccion);
        }

        public void AgregarProducto(string nombre, decimal precio, int cantidad) 
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("Nombre de producto obligatio");
            if (precio < 0) throw new ArgumentException("Precio Invalido");
            if (cantidad <= 0) throw new ArgumentException("Cantidad invalida");
            _builder.AddProducto(nombre, precio, cantidad);
        }

        public void SeleccionarEnvio(string alias) 
        {
            var strat = _factory.FromAlias(alias);
            _builder.SetEnvio(strat);
        }

        public string ObtenerResumen()
        {
            // Intentar calcular totales si ya hay envío
            decimal subtotal = 0;
            try
            {
                subtotal = (_builder as PedidoBuilder)!
                    .GetType()
                    .GetField("_pedido", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!
                    .GetValue(_builder) is Pedido p
                    ? p.Items.Sum(i => i.Total)
                    : 0;
            }
            catch { }

            var sb = new StringBuilder();
            sb.AppendLine("--- Resumen actual ---");
            sb.AppendLine($"Subtotal: ${subtotal}");
            sb.AppendLine("(El total final se calcula al confirmar, según estrategia de envío)");
            return sb.ToString();
        }

        public void ConfirmarPedido()
        {
            var pedido = _builder.Build();
            _service.Confirmar(pedido);
            _repo.Guardar(pedido);

        }
    }
}
