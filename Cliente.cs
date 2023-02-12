

namespace Linq_QueryExpression;

public class Cliente
{
    public int IdCliente { get; set; }
    public string NomeCliente { get; set; } = string.Empty;
    public List<Produto> Produtos { get; set; } = new();

}
