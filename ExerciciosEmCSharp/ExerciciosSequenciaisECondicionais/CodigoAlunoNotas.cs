using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    internal class CodigoAlunoNotas
    {
        public static void Executar()
        {
            Console.WriteLine();

            double MaiorNota = 0;
            double Ponderada1 = 0;
            double Ponderada2 = 0;
          

            Console.Write("Insira o codigo do aluno: ");
            double Codigo = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Insira o Nota 1 : ");
            double Nota_1 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Insira o Nota 2 : ");
            double Nota_2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Insira o Nota 3 : ");
            double Nota_3 = double.Parse(Console.ReadLine());

            if ((Nota_1 >= Nota_2) && (Nota_1 >= Nota_3))
            {
                MaiorNota = Nota_1;
                Ponderada1 = Nota_2;
                Ponderada2 = Nota_3;
            }
            else
                if ((Nota_2 >= Nota_1) && (Nota_2 >= Nota_3))
            {

                MaiorNota = Nota_2;
                Ponderada1 = Nota_1;
                Ponderada2 = Nota_3;
            }
            else
               if ((Nota_3 >= Nota_2) && (Nota_3 >= Nota_1))
            {
                MaiorNota = Nota_3;
                Ponderada1 = Nota_1;
                Ponderada2 = Nota_2;
            }

            double NotaPonderada = (MaiorNota * 4 + Ponderada1 * 3 + Ponderada2 * 3) / 10;

            Console.WriteLine("**********************************************************************");
            Console.WriteLine();
            Console.WriteLine($"Codigo do aluno: {Codigo}");

            Console.WriteLine();
            Console.WriteLine($"Nota 1: {Nota_1}");
            Console.WriteLine($"Nota 2: {Nota_2}");
            Console.WriteLine($"Nota 3: {Nota_3}");

            Console.WriteLine();
            Console.WriteLine($"Media Final: {NotaPonderada:F}");


            if (NotaPonderada >= 5)
            {
                Console.WriteLine("---------------------------------------ALUNO APROVADO--------------------------------------");
            }
            else
            {
                Console.WriteLine("---------------------------------------ALUNO REPROVADO--------------------------------------");
            }

          
        }
    }
}
