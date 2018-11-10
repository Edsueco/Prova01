using System;

/* 
Nome: Eduardo Alves de Melo  06: Desenvolva um sistema com a classe Cliente, onde possua os atributos
nome e cidade, porem ao se instanciar um objeto, os clientes 
já possuam uma cidade pre definida 
*/

namespace Prova06_Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia o objeto cliente passando como
            //no construtor a cidade
            Cliente c1 = new Cliente("Manaus");

            //Solicita a informação do nome do cliente e
            //armazena a informação
            Console.WriteLine("INFORME O NOME DO CLIENTE: ");
            c1.nome = Console.ReadLine();

            //Apresenta os resultados
            Console.WriteLine("\nDADOS DO CLIENTE");
            Console.WriteLine("NOME: {0} \nCIDADE: {1}", c1.nome, c1.cidade);
        }
    }
}
