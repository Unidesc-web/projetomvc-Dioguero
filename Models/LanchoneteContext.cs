using Microsoft.EntityFrameworkCore;

namespace LanchoneteApp.Models
{
    public class LanchoneteContext : DbContext
    {
        public LanchoneteContext(DbContextOptions<LanchoneteContext> options) : base(options) { }
        
        public DbSet<Produto> Produtos { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Dados iniciais
            modelBuilder.Entity<Produto>().HasData(
                new Produto { Id = 1, Nome = "X-Burger", Descricao = "Hambúrguer com queijo e salada", Preco = 15.90m, Categoria = "Lanches" },
                new Produto { Id = 2, Nome = "Coca-Cola", Descricao = "Refrigerante 350ml", Preco = 5.50m, Categoria = "Bebidas" },
                new Produto { Id = 3, Nome = "Batata Frita", Descricao = "Porção média de batata frita", Preco = 12.00m, Categoria = "Acompanhamentos" }
            );
        }
    }
}