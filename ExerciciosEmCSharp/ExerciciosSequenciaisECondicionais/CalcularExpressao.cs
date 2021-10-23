using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    class CalcularExpressao
    {
        public static void Executar()
        {

            Console.WriteLine(" ****** Calcule a Expressão **** ");

            Console.WriteLine("");
            Console.WriteLine("");

            double R, S, D;


            Console.WriteLine("Insira um numero da letra A: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um numero da letra B: ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um numero da letra C: ");
            int C = int.Parse(Console.ReadLine());

            R = Math.Pow((A + B), 2);
            S = Math.Pow((B + C), 2);
            D = (R + S) / 2;

            Console.WriteLine($"RESULTADO: {D}");


        }


    }
}
