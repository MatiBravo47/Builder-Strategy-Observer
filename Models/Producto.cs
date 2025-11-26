using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Producto
    {
        public string Nombre { get; set; } = string.Empty; //Por defecto es vacio
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        //Para el envio del correo
        public decimal Total => Precio * Cantidad;
    }
}
