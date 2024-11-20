using System.Globalization;

namespace Exercicio03_Aluno
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return (Nota1 + Nota2 + Nota3);
        }

        public void Situacao()
        {
            if (NotaFinal() >= 60.0)
            {
                System.Console.WriteLine("APROVADO");
            }
            else
            {
                System.Console.WriteLine("REPROVADO");
                double diferenca = 60.0 - NotaFinal();
                System.Console.WriteLine("FALTARAM " + diferenca.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
