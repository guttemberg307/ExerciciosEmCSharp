using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSeqüênciaisECondicionais
{
    class LigandoDoisPontos
    {
        public static void Executar()
        {
            Console.WriteLine(" ******** Distância entre dois pontos ***** ");

            Console.WriteLine();
            Console.WriteLine();

            double D;

            Console.WriteLine("Insira o ponto no plano P X1");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o ponto no plano p Y1");
            double y1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Insira o ponto no plano P Y2");
            double y2 = double.Parse(Console.ReadLine());

            
            Console.WriteLine("Insira o ponto no plano p X2");
            double x2 = double.Parse(Console.ReadLine());


           D = Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((x2 - x1), 2)));
           

            Console.WriteLine($"Resultato: {D.ToString("C")}"); // valor.ToString("C") limita a casa decimal em duas exemplo 2,12

        }
    }
}
