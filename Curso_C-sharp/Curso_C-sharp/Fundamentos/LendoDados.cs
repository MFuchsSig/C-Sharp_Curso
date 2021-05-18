using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Curso_C_sharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é seu nome ? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é sua idade ? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é seu salario ? ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write($"{nome} {idade} R${salario}");

        }
    }
}
