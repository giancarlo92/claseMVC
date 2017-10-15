using GestionDeTienda;
using InterfacesInventario.Productos;
using InterfacesInventario.Productos.Peticiones;
using InterfacesInventario.Productos.Respuestas;
using Inventario.Contextos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExample.ViewModels
{
    public class MantenimientoDeProductoVM:INotifyPropertyChanged
    {

        private NuevoProducto _nuevoProducto = new NuevoProducto();
        public NuevoProducto nuevoProducto {
            get { return _nuevoProducto; }
            set {
                this._nuevoProducto = value;
                this.OnPropertyChanged("nuevoProducto");
            }
        }

        public void GrabarProducto() {
            ProductoRegistrado nuevoProductoRegistrado =  this._gestorDeProductos.CrearProducto(this.nuevoProducto);
            this.productosResgistrados.Add(nuevoProductoRegistrado);
            this.nuevoProducto = new NuevoProducto();
        }

        public ObservableCollection<ProductoRegistrado> productosResgistrados{ get; set;}
        private IGestorDeProductos _gestorDeProductos = new GestorDeProductos();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public void CargarProductos()
        {
            this.productosResgistrados = new ObservableCollection<ProductoRegistrado>();
            _gestorDeProductos.ListarTodosLosProductos().ForEach(x=>this.productosResgistrados.Add(x));
        }
    }
}
