namespace MVCEjemplo1.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get;}
        public int Cantidad { get; set; }

        public Producto(int IdProducto, string Nombre, string Descripcion, int Cantidad)
        {
            this.IdProducto = IdProducto;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Cantidad = Cantidad;

        }




    }

    
}
