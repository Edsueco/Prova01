using System;

/*

Nome: Eduardo Alves de Melo

04: Desenvolva um algoritimo que receba uma string com
o nome completo do usuario e mostre toda string em maiuscula.

*/

namespace Prova04_letras_maiuscula
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declara a variavel nome e atribui um valor em branco
            string nome = "";

            //Solicita o nome completo do usuario e armazena seu valor 
            //na variavel nome
            Console.WriteLine("INFORME O NOME COMPLETO");
            nome = Console.ReadLine();

            //Exibe o nome completo do usuario em maiuscula
            Console.WriteLine("\nNOME COMPLETO EM LETRAS MAIUSCULA: {0}",nome.ToUpper());
        }
    }
}
