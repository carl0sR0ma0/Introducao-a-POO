using System;
using System.Globalization;

namespace ExercicioProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos p = new Produtos();
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
                        
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");         
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados atualizados:" + p);
            
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
