using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesInventario.Productos.Peticiones
{
    public class NuevoProducto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public List<int> IdsDeLasCategorias { get; set; }
        public NuevoProducto() {
            this.IdsDeLasCategorias = new List<int>();
            this.Nombre = "";
            this.Precio = 0;
        }
    }
}
