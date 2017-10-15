using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesInventario.Productos;
using InterfacesInventario.Productos.Peticiones;
using InterfacesInventario.Productos.Respuestas;
using Inventario.Contextos;
using Inventario.Modelos;

namespace GestionDeTienda
{
    public class GestorDeProductos : IGestorDeProductos
    {      
        public ProductoRegistrado ActualizarProducto(ProductoActualizado productoActualizado)
        {
            using (Tienda tienda = new Tienda())
            {
                Producto producto = tienda.Productos.Find(productoActualizado.Id);
                producto.Id = productoActualizado.Id;
                producto.Precio = productoActualizado.Precio;
                tienda.Entry(producto);
                tienda.SaveChanges();
                return ConvertirProductoA_DTO(producto);
            }
        }
        public bool BorrarProducto(int idDelProducto)
        {
            throw new NotImplementedException();
        }
        public ProductoRegistrado CrearProducto(NuevoProducto nuevoProducto)
        {
            using (Tienda tienda = new Tienda())
            {
                Producto producto = new Producto();
                producto.Nombre = nuevoProducto.Nombre;
                producto.Precio = nuevoProducto.Precio;
                //  SELECT * 
                //  FROM CATEGORY 
                //  WHERE ID IN (nuevoProducto.IdsDeLasCategorias)
                List<Categoria> categoriasElejidas=
                                    tienda.Categorias.
                                    Where(
                                        x => 
                                            nuevoProducto.IdsDeLasCategorias.Contains(x.Id)
                                    ).ToList();
                // AGREGANDO CATEGORIAS AL NUEVO PRODUCTO
                categoriasElejidas.ForEach(x => producto.Categorias.Add(x));
                //GRABANDO EL PRODUCTO
                tienda.Productos.Add(producto);
                tienda.SaveChanges();
                return ConvertirProductoA_DTO(producto);
            }
        }
        public List<ProductoRegistrado> ListarTodosLosProductos()
        {
            using (Tienda tienda = new Tienda())
            {
                return tienda.Productos.ToList().Select(x => ConvertirProductoA_DTO(x)).ToList();
            }
        }
        private ProductoRegistrado ConvertirProductoA_DTO(Producto producto) {
            ProductoRegistrado productoRegistrado = new ProductoRegistrado();
            productoRegistrado.Id = producto.Id;
            productoRegistrado.Nombre = producto.Nombre;
            productoRegistrado.Precio = producto.Precio;
            producto.Categorias.ToList()
                .ForEach(
                    x=>
                        productoRegistrado.NombresDeLasCategorias.Add(x.Nombre)
                 );
            return productoRegistrado;
        }
    }
}
