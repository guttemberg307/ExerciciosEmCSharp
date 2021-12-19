using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    internal class MaiorValor
    {
        public static void Executar()
        {

            Console.WriteLine($"Insira o valor 1: ");
            int valor_1 = int.Parse(Console.ReadLine());


            Console.WriteLine($"Insira o valor 2: ");
            int valor_2 = int.Parse(Console.ReadLine());


            Console.WriteLine($"Insira o valor 3: ");
            int valor_3 = int.Parse(Console.ReadLine());


            if ((valor_1 > valor_2) && (valor_1 > valor_3))
            {
                Console.WriteLine("Valor 1 é maior");
            }
            else
                if ((valor_2 > valor_3) && (valor_2 > valor_1))
            {
                Console.WriteLine("Valor 2 é maior");
            }

            else
               if ((valor_3 > valor_2) && (valor_3 > valor_1))
            {
                Console.WriteLine("Valor 3 é maior");
            }

            else 
            {
                Console.WriteLine("Valor 1 ,2 e 3 são iguais");
            }

        }
    }
}
