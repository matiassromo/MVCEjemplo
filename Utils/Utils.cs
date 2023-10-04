using MVCEjemplo1.Models;

namespace MVCEjemplo1.Utils
{
    public class Utils
    {
        public static List<Producto> listaProductos = new List<Producto>()
        {
            new Producto
            {
                IdProducto = 1,
                Nombre = "Producto 1",
                Descripcion = "Descripcion 1",
                Cantidad = 4
            },
            new Producto
            {
                IdProducto = 2,
                Nombre = "Producto 2",
                Descripcion = "Descripcion 2",
                Cantidad = 4
            },
            new Producto
            {
                IdProducto = 3,
                Nombre = "Producto 3",
                Descripcion = "Descripcion 3",
                Cantidad = 4
            },
            new Producto
            {
                IdProducto = 4,
                Nombre = "Producto 4",
                Descripcion = "Descripcion 4",
                Cantidad = 4
            }

        };
        
    }
}
