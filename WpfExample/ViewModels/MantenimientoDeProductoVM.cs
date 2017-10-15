using GestionDeTienda;
using InterfacesInventario.Productos;
using InterfacesInventario.Productos.Respuestas;
using Inventario.Contextos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExample.ViewModels
{
    public class MantenimientoDeProductoVM
    {
        public ObservableCollection<ProductoRegistrado> productosResgistrados;
        private IGestorDeProductos _gestorDeProductos = new GestorDeProductos();

        public void CargarProductos()
        {
            var productos = _gestorDeProductos.ListarTodosLosProductos();
            this.productosResgistrados = new ObservableCollection< ProductoRegistrado>(productos) ;
        }
    }
}
