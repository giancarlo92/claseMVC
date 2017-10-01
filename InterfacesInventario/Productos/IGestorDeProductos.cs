using InterfacesInventario.Productos.Peticiones;
using InterfacesInventario.Productos.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesInventario.Productos
{
    public interface IGestorDeProductos
    {
        ProductoRegistrado CrearProducto(NuevoProducto nuevoProducto);
        List<ProductoRegistrado> ListarTodosLosProductos();
        ProductoRegistrado ActualizarProducto(ProductoActualizado productoActualizado);
        bool BorrarProducto(int idDelProducto);
    }
}
