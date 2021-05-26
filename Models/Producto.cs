namespace Practica3.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
               
         public string Foto { get; set; }

         public string Decripcion { get; set; }

         public double Precio{ get;set;}

         public int Celular{ get;set;}

         public string Lugar { get; set; }

         public string NombreComprador { get; set; }

        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}