using GestionDeTienda;
using InterfacesInventario.Productos;
using InterfacesInventario.Productos.Peticiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaDePruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            IGestorDeProductos gestorDeProductos = new GestorDeProductos();
            NuevoProducto nuevoProducto = new NuevoProducto();
            nuevoProducto.Nombre = "Caramelo";
            nuevoProducto.Precio = 0.10;
            gestorDeProductos.CrearProducto(nuevoProducto);
        }
    }
}
