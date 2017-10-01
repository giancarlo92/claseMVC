using Inventario.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Modelos
{
    public class Producto:EntidadBase
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public ICollection<Categoria> Categorias { get; set; }
        public Producto():base() {
            this.Categorias = new HashSet<Categoria>();
        }
    }
}
