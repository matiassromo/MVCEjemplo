using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCEjemplo1.Models;
using MVCEjemplo1.Utils;

namespace MVCEjemplo1.Controllers
{
    public class ProductoController : Controller
    {
        // GET: ProductoController
        public ActionResult Index()
        {
            List<Producto> listaProductos = Utils.Utils.listaProductos;
            return View(listaProductos);
        }

        // GET: ProductoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            return View();
        }


        // GET: ProductoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        

        // GET: ProductoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

       
    }
}
