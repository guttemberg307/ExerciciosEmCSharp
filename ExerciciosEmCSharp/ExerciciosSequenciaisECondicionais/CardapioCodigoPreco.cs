using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    internal class CardapioCodigoPreco
    {
        public static void Executar()
        {
            Console.WriteLine("Insira o codigo referente ao produto cadastrado: ");
            string codigo = Console.ReadLine();

            Console.WriteLine("Insira a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            switch (codigo)
            {

                case "100":
                    Console.WriteLine("Cachorro-quente: ");
                    double preco = quantidade * 1.20;
                    Console.WriteLine($"valor total: R$ {preco:F}");

                    break;

                case "101":
                    Console.WriteLine("Bauru simples: ");
                    double preco1 = quantidade * 1.30;
                    Console.WriteLine($"valor total: R$ {preco1:F}");

                    break;

                case "102":
                    Console.WriteLine("Bauru com ovos: ");
                    double preco2 = quantidade * 1.50;
                    Console.WriteLine($"valor total: R$ {preco2:F}");

                    break;

                case "103":
                    Console.WriteLine("Bauru Hambúrger: ");
                    double preco3 = quantidade * 1.20;
                    Console.WriteLine($"valor total: R$ {preco3:F}");

                    break;

                case "104":
                    Console.WriteLine("Bauru Cheeseburguer: ");
                    double preco4 = quantidade * 1.30;
                    Console.WriteLine($"valor total: R$ {preco4:F}");

                    break;

                case "105":
                    Console.WriteLine("Bauru Refrigerante: ");
                    double preco5 = quantidade * 1.00;
                    Console.WriteLine($"valor total: R$ {preco5:F}");

                    break;

                    default: Console.WriteLine("Codigo não cadastrado");
                    break;
            }


        }
    }
}
