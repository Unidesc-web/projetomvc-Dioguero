using System.ComponentModel.DataAnnotations;

namespace LanchoneteApp.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Telefone é obrigatório")]
        [StringLength(20)]
        public string Telefone { get; set; } = string.Empty;
        
        [StringLength(200)]
        public string? Endereco { get; set; }
        
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string? Email { get; set; }
        
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        
        // Relacionamento
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}