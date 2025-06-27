using System.ComponentModel.DataAnnotations;

namespace LanchoneteApp.Models
{
    public class PedidoItem
    {
        public int Id { get; set; }
        
        [Required]
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; } = null!;
        
        [Required]
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; } = null!;
        
        [Required]
        [Range(1, 100, ErrorMessage = "Quantidade deve ser entre 1 e 100")]
        public int Quantidade { get; set; }
        
        [Required]
        public decimal PrecoUnitario { get; set; }
        
        public decimal Subtotal => Quantidade * PrecoUnitario;
        
        [StringLength(200)]
        public string? Observacoes { get; set; }
    }
}