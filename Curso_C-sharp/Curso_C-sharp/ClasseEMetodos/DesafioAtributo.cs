using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_sharp.ClasseEMetodos
{
    class DesafioAtributo
    {
        int a = 10;

        public static void Executar()
        {
             // Acessar a variacel 'a'  dentro do metodo Executar!
            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}
