using GestionDeTienda;
using InterfacesInventario.Productos;
using InterfacesInventario.Productos.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ProductosController : Controller
    {
        private IGestorDeProductos _gestorDeProductos = new GestorDeProductos();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _TablaDeProductos()
        {
            List<ProductoRegistrado> listaDeProductos = _gestorDeProductos.ListarTodosLosProductos();
            return View(listaDeProductos);
        }
    }
}