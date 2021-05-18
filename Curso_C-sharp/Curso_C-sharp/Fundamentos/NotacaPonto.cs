using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_sharp.Fundamentos
{
    class NotacaPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " world! ") .Replace(" wordl! ", " Mundo! ");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            String valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
