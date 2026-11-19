
using System.ComponentModel.DataAnnotations;

namespace SistemaEstoque.Models;

public class Produto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o nome.")]
    public string Nome { get; set; } = "";

    [Range(0.01, 100000,
        ErrorMessage = "Preço maior que zero.")]
    public decimal Preco { get; set; }
}
