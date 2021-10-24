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
                {"Exercicio N° 1 - Ligando Dois Pontos",LigandoDoisPontos.Executar},
                {"Exercicio N° 2 - Calcular Expressão",CalcularExpressao.Executar},
                {"Exercicio N° 3 - IdadePessoa 1", IdadePessoa_1.Executar }

            });
             central.SelecionarEExecutar();
        } 
        }
}
