using ExerciciosEmCSharp.ExerciciosSeqüênciaisECondicionais;
using ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais;
using System;
using System.Collections.Generic;
namespace ExerciciosEmCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {

                //{"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Exercicio = Ligando Dois Pontos", LigandoDoisPontos.Executar},
                {"Exercicio = Calcular Expressão", CalcularExpressao.Executar},
                {"Exercicio = Idade Pessoa 1", IdadePessoa_1.Executar },
                {"Exercicio = Idade Pessoa 2", IdadePessoa_2.Executar},
                {"Exercicio = Media Aluno Nota", MediaAlunoNota.Executar},
                {"Exercicio = Duracao Evento Fabrica",DuracaoEventoFabrica.Executar},
                {"Exercicio = Custo Novo Consumidor Carro",CustoNovoConsumidorCarro.Executar},
                {"Exercicio = Nota Aluno Aprovado Ou Reprovado", NotaAlunoAprovadoOuReprovado.Executar},
                {"Exercicio = Maior valor de 3 ", MaiorValor.Executar},
                {"Exercicio = Multiplos E Nao Multiplos ", MultiplosENaoMultiplos.Executar},
                {"Exercicio = Idade Nadador Classicacao ",  IdadeNadadorClassicacao.Executar},
                {"Exercicio = Codigo Aluno Notas ",  CodigoAlunoNotas.Executar},
                {"Exercicio = Par Impar Positivo Negativo ",  ParImparPositivoNegativo.Executar},
                {"Exercicio = Cardapio Codigo Preco ",   CardapioCodigoPreco.Executar}
               

            });
             central.SelecionarEExecutar();
        } 
        }
}
