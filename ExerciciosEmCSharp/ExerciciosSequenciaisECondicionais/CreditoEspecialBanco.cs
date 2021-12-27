using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    internal class CreditoEspecialBanco
    {
        public static void Executar()
        {
            Console.WriteLine("Insira seu saldo médio do ultimo ano: ");
            double saldo = double.Parse(Console.ReadLine());

            if (saldo <= 200)
            {
                Console.WriteLine("Nenhum crédito");
            }
            else
               if(saldo <= 400)
            {
                double Credito = (saldo * 1.20) - saldo;
                Console.WriteLine($"Seu credito é pré - aprovado no valor de: R${Credito}");
            }
            else
               if (saldo <= 600)
            {
                double Credito = (saldo * 1.30) - saldo;
                Console.WriteLine($"Seu credito é pré - aprovado no valor de: R${Credito}");
            }
            else
               if (saldo >= 601)
            {
                double Credito = (saldo * 1.40) - saldo;
                Console.WriteLine($"Seu credito é pré - aprovado no valor de: R${Credito}");
            }

        }

    }
}
