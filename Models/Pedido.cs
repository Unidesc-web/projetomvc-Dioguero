using System.ComponentModel.DataAnnotations;

namespace LanchoneteApp.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        
        [Required]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;
        
        public DateTime DataPedido { get; set; } = DateTime.Now;
        
        [Required(ErrorMessage = "Status é obrigatório")]
        public StatusPedido Status { get; set; } = StatusPedido.Pendente;
        
        public decimal ValorTotal { get; set; }
        
        [StringLength(500)]
        public string? Observacoes { get; set; }
        
        // Relacionamento
        public List<PedidoItem> Itens { get; set; } = new List<PedidoItem>();
    }
    
    public enum StatusPedido
    {
        Pendente,
        Preparando,
        Pronto,
        Entregue,
        Cancelado
    }
}