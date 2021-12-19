using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    internal class CustoNovoConsumidorCarro
    {

        public static void Executar()
        {

            Console.WriteLine();
            Console.WriteLine();

            double PorcentagemDistribuidor;
            double Impostos;
            double soma;
            
            Console.Write("Insira o valor de custo do carro: ");
            double custo = int.Parse(Console.ReadLine());

            PorcentagemDistribuidor = (custo * 1.28) - custo;
            Impostos = (custo * 1.45) - custo;

            soma = PorcentagemDistribuidor + Impostos + custo;

            Console.WriteLine($"Valor de custo final do carro com impostos inclusos:{soma}");

        }
    }
}
