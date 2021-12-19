using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    internal class MultiplosENaoMultiplos
    {
        public static void Executar()
        {
            Console.Write("Insira o valor de A: ");
            int valor_A = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor de B: ");
            int valor_B = int.Parse(Console.ReadLine());

            if (valor_A % valor_B == 0)
            {
                Console.Write("São multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }
        }
    }
}
