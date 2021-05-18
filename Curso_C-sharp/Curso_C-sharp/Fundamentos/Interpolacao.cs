using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_sharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            String nome = "Notbook gamer";
            String marca = "Dell";
            double preco = 5800.00;
            Console.WriteLine(" O " + nome +" da Marca " + marca + " Custa " +preco );
            Console.WriteLine(" O {0} da marca {1} custa {2} ", nome, marca, preco);
            Console.WriteLine($" A Marca {marca} é Legal! ");
            Console.WriteLine($" 1+1={1+1}! ");
            
        }
    }
}
