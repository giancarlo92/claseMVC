using Inventario.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Contextos
{
    public class Tienda:DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public Tienda() : base("BaseDeDatosDeLaTienda") {
        }
    }
}
