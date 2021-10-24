using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    class IdadePessoa_2
    {
        public static void Executar()
        {
            Console.WriteLine("****  Idade Pessoa 2 *******");

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Insira a sua idade expressa em dias: ");
            int dias = int.Parse(Console.ReadLine());


            int ano = (dias / 365);
            int mes = (dias % 365) / 30;
            int dia = (dias % 365) % 30;

            Console.WriteLine($"Resultado: dia:{dia} /mês:{mes} /ano:{ano}");
        }

    }
}
