//Deafio escolhido = caixa Eletronico
//Link : http://dojopuzzles.com/problemas/exibe/caixa-eletronico/
using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas = {100, 50, 20, 10, 5, 2, 1};
            System.Console.WriteLine("Bem vindo ao meu Caixa eletrônico :)\nDigite o valor do saque:");
            int saque = int.Parse(Console.ReadLine());

            int qtNotas  = 0;

            for (int i = 0; i < notas.Length; i++){
                qtNotas = saque/notas[i];
                saque = saque%notas[i];
                if(qtNotas != 0){
                    System.Console.WriteLine($"Você recebeu {qtNotas} notas de {notas[i]}");
                }
            }
            System.Console.WriteLine("---------Fim--------");
        }
    }
}
