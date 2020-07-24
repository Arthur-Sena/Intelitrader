using System;

namespace AnoBissexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bem Vindo ao verificador de anos bissextos\nDigite o ano que deseja verificar: ");
            int ano = int.Parse(Console.ReadLine());
            int verificador = ano%4;
            int verificador2 = ano%100;
            int verificador3 = ano%400;
            if(verificador == 0 && verificador2 != 0 || verificador3 == 0){
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"O ano {ano} é bissexto");
                Console.ResetColor();
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{ano} não é um ano bissexto");
                Console.ResetColor();
            }
        }
    }
}
