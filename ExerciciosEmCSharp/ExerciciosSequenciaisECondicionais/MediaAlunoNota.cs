using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    class MediaAlunoNota
    {
        public static void Executar() 
        {
            string aluno;


            Console.WriteLine("---------Média Ponderada ---------");

            Console.WriteLine();
            Console.WriteLine();


            Console.Write("Nome aluno: ");
            aluno = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Insira nota 1:");
            double Nota_1 = double.Parse(Console.ReadLine());

            Console.Write("Insira nota 2:");
            double Nota_2 = double.Parse(Console.ReadLine());

            Console.Write("Insira nota 3:");
            double Nota_3 = double.Parse(Console.ReadLine());


            double Resultado = ((Nota_1 * 2) + (Nota_2 * 3) + (Nota_3 * 5)) / 10;

            Console.WriteLine( $" A Nota ponderada do aluno: {aluno} é {Resultado}");


            
        
        }
    }
}
