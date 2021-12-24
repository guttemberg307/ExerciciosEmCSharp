using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    internal class CalculoPesoIdeal
    {

   
        public static void Executar()
        {
            Console.WriteLine("Insira o seu sexo: (M) Masculino ou (F) Feminino: ");
            string sexo = Console.ReadLine();

            Console.WriteLine("Insira a sua altura: ");
            double Altura = double.Parse(Console.ReadLine());

            switch (sexo)
            {
                case "M":
                case "m":

                    double peso1 = (72.7 * Altura) - 58;
                    Console.WriteLine($"Sexo Masculino, peso ideal: {peso1:F}");

                    break;

                case "F":
                case "f":

                    double peso = (62.1 * Altura) - 44.7;
                    Console.WriteLine($"Sexo Feminino, peso ideal: {peso:F}");

                    break;

                default:
                    Console.WriteLine("sexo não cadastrado no sistema ");

                    break;
            }
        }
    }
}
