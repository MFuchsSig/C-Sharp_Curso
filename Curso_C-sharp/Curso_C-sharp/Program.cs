using System;
using System.Collections.Generic;
using System.Text;
using Curso_C_sharp.Fundamentos;
using Curso_C_sharp.EstruturasDeControle;
using Curso_C_sharp.ClasseEMetodos;
namespace Curso_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", operadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", operadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", operadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", operadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", operadoresUnarios.Executar},
                
                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                //Classe e Métodos
                {"Mebros - Classe e Metodos", Mebros.Executar},
                {"Construtores - Classe e Metodos", Construtores.Executar},
                {"Metodos Com Retorno - Classe e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classe e Metodos", MetodosEstaticos.Executar},
                {"Atributos estaticos - Classe e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Desafio",DesafioAtributo.Executar},
                {"Parametro - Classe e Metodos", Params.Executar},
                {"Parametro Nomeados - Classe e Metodos", ParametrosNomeados.Executar},
                {"Get Set - Classe e Metodos", GetSet.Executar},
                {"Propriedades - Classe e Metodos", Props.Executar},
                {"Readonly - Classe e Metodos", Readonly.Executar},
                {"Exemplo Enum - Classe e Metodos", ExemploEnum.Executar},
                {"Exemplo Struct  - Classe e Metodos", ExemploStruct.Executar},
                {"Struct VS Classe - Classe e Metodos", StructVsClasse.Executar},
                {"Valor VS Referencia - Classe e Metodos", ValorVsReferencia.Executar},
                {"Parametros Por Referencia - Classe e Metodos", ParametrosPorReferencia.Executar},
                {"Parametros Padrão - Classe e Metodos", ParametroPadrao.Executar},
            });
            central.SelecionarEExecutar();
        }
    }
}

