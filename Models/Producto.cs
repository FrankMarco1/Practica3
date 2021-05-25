namespace Practica3.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
       
        public Categoria Categoria { get; set; }

         public string Foto { get; set; }

        public int CategoriaId { get; set; }
    }
}