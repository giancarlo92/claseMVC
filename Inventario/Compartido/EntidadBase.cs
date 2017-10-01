using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Compartido
{
    public class EntidadBase
    {
        public int Id { get; set; }
        public DateTime DiaHoraDeCreacion { get; set; }
        public DateTime DiaHoraDeUltimaModificacion { get; set; }
        public EntidadBase() {
            this.DiaHoraDeCreacion = DateTime.Now;
            this.DiaHoraDeUltimaModificacion = DateTime.Now;
        }
    }
}
