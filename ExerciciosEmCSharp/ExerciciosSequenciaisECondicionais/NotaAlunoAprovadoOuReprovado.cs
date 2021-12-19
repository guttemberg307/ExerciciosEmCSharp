using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    internal class NotaAlunoAprovadoOuReprovado
    {
        public static void Executar()
        {
            

            Console.WriteLine("Insira nome aluno:");
            string aluno = Console.ReadLine();

            Console.WriteLine("Insira nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());


            double Media =  (nota1 + nota2 + nota3)/2;

            Console.WriteLine($"A media do aluno:{Media:F}");//  :F formata as cadas decimais para duas casas 

            if (Media >= 6.0)
            {
                Console.WriteLine("Aluno Aprovado: Media superior a 6");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado: Media inferior a 6");
            }
        }
    }
}
