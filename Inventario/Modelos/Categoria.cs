using Inventario.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Modelos
{
    public class Categoria:EntidadBase
    {
        public string Nombre { get; set; }
        public ICollection<Producto> Productos { get; set; }
        public Categoria():base(){
            this.Productos=new HashSet<Producto>();
        }

    }
}
