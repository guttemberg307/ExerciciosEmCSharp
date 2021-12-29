using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    internal class EscolhaMediaAluno
    {
        public static void Executar()
        {

            Console.Write("Insira nota 1: ");
            double nota_1 = double.Parse(Console.ReadLine());


            Console.Write("Insira nota 2: ");
            double nota_2 = double.Parse(Console.ReadLine());


            Console.Write("Insira nota 3: ");
            double nota_3 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Escolha qual média você quer usar, insira um número");
            Console.WriteLine("");


            Console.WriteLine("1 - Aritimetica");
            Console.WriteLine("2 - Ponderada");
            Console.WriteLine("3 - Harmônica");
            Console.WriteLine("");
            string media = Console.ReadLine();

            Console.WriteLine("");

            switch (media)
            {
                case "1":
                    double Aritimetica = (nota_1 + nota_2 + nota_3);
                    Console.WriteLine($"O Resultado da Média Aritimetica:{Aritimetica}");
                    break;

                case "2":
                    double Ponderada = (nota_1 * 3 + nota_2 * 3 + nota_3 * 4) / 10;
                    Console.WriteLine($"O Resultado da Média Ponderada:{Ponderada}");
                    break;

                case "3":
                    double Harmonica = 3/(1/nota_1 + 1/nota_2 + 1/nota_3) ;
                    Console.WriteLine($"O Resultado da Média Harmonica:{Harmonica:F}");
                    break;
                    
                    default: Console.WriteLine("Média não registrada");
                    break;
            }
        }
    }
}
