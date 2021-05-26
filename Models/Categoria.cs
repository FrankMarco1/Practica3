using System.Collections.Generic;

namespace Practica3.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }


        public ICollection<Producto> Productos { get; set; }
    }
}