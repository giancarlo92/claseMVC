using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesInventario.Productos.Respuestas
{
    public class ProductoRegistrado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public List<string> NombresDeLasCategorias { get; set; }
        public ProductoRegistrado()
        {
            this.NombresDeLasCategorias = new List<string>();
        }
    }
}
