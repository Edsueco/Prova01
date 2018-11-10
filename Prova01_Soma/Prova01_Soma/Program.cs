using System;
/*
Nome: Eduardo Alves de Melo

01: Sem orientação a objeto, crie um algoritimo 
que receba dois valores e em seguida faça a soma dos
dois valores e exiba na tela.

*/
namespace Prova01_Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            int num1, num2;

            //Solicita numero 1 e armazena;
            Console.WriteLine("INFORME DOIS NUMEROS");
            Console.Write("NUMERO 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            //Solicita numero 2 e armazena;
            Console.Write("NUMERO 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Exibe o resultado
            Console.WriteLine("RESULTADO: {0} + {1} = {2}", num1,num2,(num1+num2));
        }
    }
}
