using System.ComponentModel.DataAnnotations;

namespace Exercicio.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Nome obrigatório")]
        public string Nome { get; set; }
        [Range(0, int.MaxValue, ErrorMessage ="Quantidade tem que ser maior que 0")]
        public int Quantidade { get; set; }
    }
}
