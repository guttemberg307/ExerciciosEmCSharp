using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosEmCSharp.ExerciciosSequenciaisECondicionais
{
    internal class DuracaoEventoFabrica
    {
        public static void Executar()
        {
            Console.WriteLine("");
            Console.WriteLine("");

            double Horas;
            double Minutos;
            
            Console.WriteLine("Insira o tempo de duração em segundos");
            int Segundos = int.Parse(Console.ReadLine());

            Horas = Segundos / 3600; // 1 Hora é 3600 segundos
            Minutos = (Segundos % 3600) / 60; // resto da divisão dividido por 60 minutos
            Segundos = (Segundos % 60) % 60;

            Console.WriteLine($"{Horas}h {Minutos}m {Segundos}s");

        }
    }
}
