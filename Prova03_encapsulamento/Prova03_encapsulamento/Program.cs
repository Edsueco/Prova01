using System;
/*

Nome: Eduardo Alves de Melo

03: Crie a classe animal e sem propriedades, encapsule 
os atributos raça e nome da mesma, tornando acessiveis
sua chamada ao serem instanciadas, teste a mesma.

*/
namespace Prova03_encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando o objeto a1 da classe Animal
            Animal a1 = new Animal();

            //Solicitando o nome do animal e armazenando o valor
            Console.WriteLine("INFORME O NOME E A RAÇA DO ANIMAL");
            Console.Write("NOME: ");
            a1.setNome(Console.ReadLine());

            //Solicitando a raça do animal e armazenando o valor
            Console.Write("RAÇA: ");
            a1.setRaca(Console.ReadLine());

            //Apresentando o resultado
            Console.WriteLine("\nDADOS INFORMADOS");
            Console.WriteLine("NOME: {0}", a1.getNome());
            Console.WriteLine("RAÇA: {0}", a1.getRaca());
        }
    }
}
