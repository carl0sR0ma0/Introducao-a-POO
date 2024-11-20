using System;
using System.Globalization;

namespace ExercicioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito incial (S/N)? ");
            char opcao = char.Parse(Console.ReadLine());

            Conta c;

            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre o valor depósito incial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numero, nome, valorInicial);
            }
            else
            {
                c = new Conta(numero, nome);
            }

            Console.WriteLine("\nDados da conta: ");     
            Console.WriteLine(c);

            Console.Write("\nEntre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Depositar(valor);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
            
            Console.Write("\nEntre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Sacar(valor);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
        }
    }
}
