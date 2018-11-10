using System;

/*

Nome: Eduardo Alves de Melo

05: Desenvolva um sistema, onde seja solicitado um valor e
uma operação de calculo, seja soma, subtração, multiplicação e divisão
em seguida mostre a construção dinamica da tabuada do valor solicitado

*/

namespace Prova05_tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declara as variaveis num e op
            int num;
            string op;

            //Solicita a informação de numero e armazena
            Console.Write("INFORME UM NUMERO: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Solicita a informação do operador e armazena
            Console.Write("INFORME O OPERADOR: ");
            op = Console.ReadLine();

            //Monta a tabuada solicitada
            for (int i = 1; i < 10; i++){
                if (op == "+") { Console.WriteLine("{0} + {1} = {2}",num,i,num+i); }
                else if (op == "-") { Console.WriteLine("{0} - {1} = {2}", num, i, num - i); }
                else if (op == "*") { Console.WriteLine("{0} * {1} = {2}", num, i, num * i); }
                else if (op == "/") { Console.WriteLine("{0} / {1} = {2}", num, i, num / i); }
            }
        }
    }
}
