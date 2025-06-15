using System.ComponentModel.DataAnnotations;

namespace LanchoneteApp.Models
{
    public class Produto
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string? Descricao { get; set; }
        
        [Required(ErrorMessage = "Preço é obrigatório")]
        [Range(0.01, 999.99, ErrorMessage = "Preço deve estar entre R$ 0,01 e R$ 999,99")]
        public decimal Preco { get; set; }
        
        [Required(ErrorMessage = "Categoria é obrigatória")]
        [StringLength(50)]
        public string Categoria { get; set; } = string.Empty;
        
        public bool Disponivel { get; set; } = true;
    }
}