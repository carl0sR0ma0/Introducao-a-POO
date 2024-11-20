using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioBanco
{
    public class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Titular = nome;
        }

        public Conta(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= (valor + 5.00);
        }

        public override string ToString()
        {
            return "Conta "
            + Numero
            + ", Titular: "
            + Titular
            + ", Saldo: $ "
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
