namespace Linq_QueryExpression;
class Program
{
    static void Main(string[] args)
    {
        Cliente cliente1 = new Cliente
        {
            IdCliente = 1,
            NomeCliente = "Maria da Costa",
            Produtos = {
                new Produto{IdProduto = 1,
                NomeProduto = "Computador",
                PrecoProduto = 12.500},
                new Produto{IdProduto = 2,
                NomeProduto = "Mouse",
                PrecoProduto = 7.25
                }
            }
        };
        Cliente cliente2 = new Cliente
        {
            IdCliente = 2,
            NomeCliente = "Pedro Rosario",
            Produtos = {
                new Produto{IdProduto = 3,
                NomeProduto = "Mesa Misturadora",
                PrecoProduto = 52.500},
                new Produto{IdProduto = 4,
                NomeProduto = "Piano",
                PrecoProduto = 9.25
                },
                new Produto{IdProduto = 5,
                NomeProduto = "Canos de som",
                PrecoProduto = 2.25
                }
            }
        };

        List<Cliente> clientes = new();
        clientes.Add(cliente1);
        clientes.Add(cliente2);

        var resultado = from cli in clientes
                        from pro in cli.Produtos
                        select new
                        {
                            NomeCli = cli.NomeCliente,
                            NomePro = pro.NomeProduto,
                            precoPro = pro.PrecoProduto
                        };
        foreach (var res in resultado)
        {
            Console.WriteLine($"Clinete: {res.NomeCli}, [Porduto: {res.NomePro} - Preço: {res.precoPro}]");
        }

    }
}
