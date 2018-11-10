using System;
/*
Nome: Eduardo Alves de Melo

02: Desenvolva um algoritimo que receba três strings e no
final seja exibida a concatenação de todas elas.

*/
namespace Prova02_concatenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declara a variavel "palavra" e atribui o valor em branco
            string palavra = "";

            //Solicita a digitação da palavra 1 e armazena seu valor 
            //atribuindo um espaço em branco no final
            Console.WriteLine("INFORME TRES PAVAVRAS");
            Console.Write("PALAVRA 1: ");
            palavra = Console.ReadLine()+" ";

            //Solicita a digitação da palavra 2, concatena com a palavra 
            //anterior atribuindo um espaço no final
            Console.Write("PALAVRA 2: ");
            palavra += Console.ReadLine() + " ";

            //Solicita a digitação da palavra 3, concatena com a palavra 
            //anterior atribuindo um espaço no final
            Console.Write("PALAVRA 3: ");
            palavra += Console.ReadLine() + " ";

            //Exibe o resultado
            Console.WriteLine("RESULTADO: {0}",palavra);
        }
    }
}
