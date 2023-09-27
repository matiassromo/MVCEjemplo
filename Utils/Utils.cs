using MVCEjemplo1.Models;

namespace MVCEjemplo1.Utils
{
    public class Utils
    {
        public static List<Producto> listaProductos = new List<Producto>()
        {
            new Producto(1, "Producto1", "Desc1", 3),
            new Producto(2, "Producto2", "Desc2", 4),
            new Producto(3, "Producto3", "Desc3", 8, ""),
            new Producto(4, "Producto4", "Desc4", 3, ""),

        };
        
    }
}
