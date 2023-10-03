using MVCEjemplo1.Models;

namespace MVCEjemplo1.Utils
{
    public class Utils
    {
        public static List<Producto> listaProductos = new List<Producto>()
        {
            new Producto(1, "Producto 1", "Descripcion 1", 3),
            new Producto(2, "Producto 2", "Descripcion 2", 4),
            new Producto(3, "Producto 3", "Descripcion 3", 8),
            new Producto(4, "Producto 4", "Descripcion 4", 3),

        };
        
    }
}
