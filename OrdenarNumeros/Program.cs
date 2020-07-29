using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {

            int []vetorNumero= new int[3];
            int i;

            for(i=0;i<3;i++) {
                Console.Write("Digite o {0}º numero: ",i+1);
                vetorNumero[i]=Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(vetorNumero);

            System.Console.Write("A ordem é:");
            for (i = 0; i < 3; i++) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" {vetorNumero[i]}");
                Console.ResetColor();
            }
        }
    }
}
