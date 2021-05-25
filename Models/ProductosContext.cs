using Microsoft.EntityFrameworkCore;

namespace Practica3.Models
{
    public class ProductosContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public ProductosContext(DbContextOptions dco) : base(dco) {

        }
    }
}