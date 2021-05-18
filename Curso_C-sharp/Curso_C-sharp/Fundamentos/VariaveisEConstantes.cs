using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_sharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area de circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.14521;
            // Nao da para mudar um const
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo ? "+ estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols "+ saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("salario "+ salario);

            int menorValorInt = int.MinValue; //mais usado dos interios!
            Console.WriteLine("Menor int "+ menorValorInt);


            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong PolulacaoMundial = 7_600_000_000;
            Console.WriteLine("População mudial "  + PolulacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador " + precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor Aplle " +valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre as estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de c#";
            Console.WriteLine("Texto " + texto);






        }
    }
}
