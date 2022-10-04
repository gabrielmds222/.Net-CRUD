using System.ComponentModel.DataAnnotations;

namespace CrudDotnet.Models
{
    public class Product
    {
        [Key]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(40, ErrorMessage = "Este campo deve conter entre 3 e 40 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 40 caracteres")]

        public string Produto { get; set; }

        [MaxLength(250, ErrorMessage = "Este campo deve conter no máximo 250 caracteres")]

        public string Descricao { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]

        public int Estoque { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public double Preco { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]

        public int CategoryId { get; set; }
    }
}