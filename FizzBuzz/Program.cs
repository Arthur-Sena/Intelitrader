using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            System.Console.WriteLine("Desafio FizzBuzz");

            while (contador <=100){
                if(contador%3==0 && contador%5 != 0){
                    System.Console.WriteLine("Fizz");
                }if(contador%5 == 0 && contador%3 != 0){
                    System.Console.WriteLine("Buzz");
                }if(contador%3==0 && contador%5==0){
                    System.Console.WriteLine("FizzBuzz");
                }if(contador%3 != 0 && contador%5 != 0){
                    System.Console.WriteLine(contador);
                }
                contador = contador+1;
            }
        }
    }
}
