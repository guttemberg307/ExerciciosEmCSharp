using ExerciciosEmCSharp.ExerciciosSeqüênciaisECondicionais;
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
                {"Exercicio N° 1 - LigandoDoisPontos",LigandoDoisPontos.Executar}

            });
             central.SelecionarEExecutar();
        } 
        }
}
