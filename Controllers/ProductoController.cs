using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCEjemplo1.Models;
using MVCEjemplo1.Utils;

namespace MVCEjemplo1.Controllers
{
    public class ProductoController : Controller
    {
        // GET: ProductoController
        public IActionResult Index()
        {
            List<Producto> listaProductos = Utils.Utils.listaProductos;
            return View(listaProductos);
        }

        // GET: ProductoController/Details
        public IActionResult Details(int IdProducto)
        {
            Producto producto2 = Utils.Utils.listaProductos.Find(x => x.IdProducto == IdProducto);
            if(producto2!= null)
            {
                return View(producto2);
            }
            return RedirectToAction("Index");
        }

        // GET: ProductoController/Create
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            int i = Utils.Utils.listaProductos.Count() + 1;
            producto.IdProducto = i;
            Utils.Utils.listaProductos.Add(producto);
            return RedirectToAction("Index");
        }


        // GET: ProductoController/Edit/5
        public IActionResult Edit(int IdProducto)
        {
            Producto producto = Utils.Utils.listaProductos.Find(x=>x.IdProducto ==IdProducto);
            if(producto != null)
            {
                return View(producto);
            }
                return RedirectToAction("Index");
            
            
        }

        [HttpPost]
        public IActionResult Edit(Producto producto)
        {
            Producto producto2 = Utils.Utils.listaProductos.Find(x => x.IdProducto == producto.IdProducto);
            if (producto2 != null)
            {
                producto2.Nombre = producto.Nombre;
                producto2.Cantidad = producto.Cantidad;
                producto2.Descripcion = producto.Descripcion;
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: ProductoController/Delete/5
        public IActionResult Delete(int IdProducto)
        {
            Producto producto2 = Utils.Utils.listaProductos.Find(x => x.IdProducto == IdProducto);
            if (producto2 != null)
            {
                Utils.Utils.listaProductos.Remove(producto2);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

       
    }
}
