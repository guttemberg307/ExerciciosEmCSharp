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
                {"Exercicio - Ligando Dois Pontos", LigandoDoisPontos.Executar},
                {"Exercicio - Calcular Expressão", CalcularExpressao.Executar},
                {"Exercicio - Idade Pessoa 1", IdadePessoa_1.Executar },
                {"Exercicio = Idade Pessoa 2", IdadePessoa_2.Executar},
                {"Exercicio = Media Aluno Nota", MediaAlunoNota.Executar},
                {"Exercicio = Duracao Evento Fabrica",DuracaoEventoFabrica.Executar},
                {"Exercicio = Custo NovoConsumidor Carro",CustoNovoConsumidorCarro.Executar}


                
    

            });
             central.SelecionarEExecutar();
        } 
        }
}
