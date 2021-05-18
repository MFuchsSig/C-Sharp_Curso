using System;
using System.Collections.Generic;
using System.Text;

namespace Curso_C_sharp.Fundamentos
{
    class operadoresTernario
    {
        public static void Executar()
        {
            var nota = 9.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento
                ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}