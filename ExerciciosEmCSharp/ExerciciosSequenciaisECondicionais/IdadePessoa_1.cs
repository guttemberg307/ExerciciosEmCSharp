using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    class IdadePessoa_1
    {
        public static void Executar()
        {

            Console.WriteLine("Idade pessoa  Meses, Dias e Anos");

            Console.WriteLine("Insira a sua Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a sua Mês: ");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a sua Ano: ");
            int ano = int.Parse(Console.ReadLine());


            int resultado = (idade * 365) + (mes * 30);

            Console.WriteLine($"Quantidade de dias referente a anos:{resultado}");


        }

    }
}
