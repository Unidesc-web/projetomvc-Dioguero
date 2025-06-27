using Microsoft.EntityFrameworkCore;

namespace LanchoneteApp.Models
{
    public class LanchoneteContext : DbContext
    {
        public LanchoneteContext(DbContextOptions<LanchoneteContext> options) : base(options) { }
        
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoItem> PedidoItens { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar relacionamentos
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.ClienteId);
                
            modelBuilder.Entity<PedidoItem>()
                .HasOne(pi => pi.Pedido)
                .WithMany(p => p.Itens)
                .HasForeignKey(pi => pi.PedidoId);
                
            modelBuilder.Entity<PedidoItem>()
                .HasOne(pi => pi.Produto)
                .WithMany()
                .HasForeignKey(pi => pi.ProdutoId);
            
            // Configurar precisão decimal
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasPrecision(10, 2);
                
            modelBuilder.Entity<Pedido>()
                .Property(p => p.ValorTotal)
                .HasPrecision(10, 2);
                
            modelBuilder.Entity<PedidoItem>()
                .Property(pi => pi.PrecoUnitario)
                .HasPrecision(10, 2);
            
            // Dados iniciais
            modelBuilder.Entity<Produto>().HasData(
                new Produto { Id = 1, Nome = "X-Burger", Descricao = "Hambúrguer com queijo e salada", Preco = 15.90m, Categoria = "Lanches" },
                new Produto { Id = 2, Nome = "Coca-Cola", Descricao = "Refrigerante 350ml", Preco = 5.50m, Categoria = "Bebidas" },
                new Produto { Id = 3, Nome = "Batata Frita", Descricao = "Porção média de batata frita", Preco = 12.00m, Categoria = "Acompanhamentos" },
                new Produto { Id = 4, Nome = "X-Salada", Descricao = "Hambúrguer com alface, tomate e queijo", Preco = 18.50m, Categoria = "Lanches" },
                new Produto { Id = 5, Nome = "Suco Natural", Descricao = "Suco natural de laranja 300ml", Preco = 7.00m, Categoria = "Bebidas" },
                new Produto { Id = 6, Nome = "Sorvete", Descricao = "Sorvete de chocolate com cobertura", Preco = 8.90m, Categoria = "Sobremesas" }
            );
            
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Nome = "João Silva", Telefone = "(11) 99999-1111", Endereco = "Rua A, 123", Email = "joao@email.com", DataCadastro = DateTime.Now },
                new Cliente { Id = 2, Nome = "Maria Santos", Telefone = "(11) 88888-2222", Endereco = "Rua B, 456", Email = "maria@email.com", DataCadastro = DateTime.Now }
            );
        }
    }
}