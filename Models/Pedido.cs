using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pedido
    {
        public List<Producto> Items { get; set; } = new();

        //datos del cliente 
        public string ClienteNombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        
        //Observers cliente
        public string EnvioNombre { get; set; } = string.Empty;
        public int Total { get; set; }
    }
}
