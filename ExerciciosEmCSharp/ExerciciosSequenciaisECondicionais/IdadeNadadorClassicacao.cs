using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    internal class IdadeNadadorClassicacao
    {
        public static void  Executar()
        {
            
            Console.Write("Insira a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade <= 4)
            {
                Console.WriteLine("Idade nao existe na categoria");
            }
            else if(idade <= 7)
            {
                Console.WriteLine("Categoria infantil A");
            }
            else if(idade <= 10)
            {
                Console.WriteLine("Categoria infantil B");
            }
            else if(idade <= 13)
            {
                Console.WriteLine("Categoria juvenil A");
            }
            else if(idade <= 17)
            {
                Console.WriteLine("Categoria juvenil B");
            }
            else
            {
                Console.WriteLine("Adulto");
            }

        }
    }
}
