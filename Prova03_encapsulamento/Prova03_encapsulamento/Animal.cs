using System;

/*
Nome: Eduardo Alves de Melo

03: Crie a classe animal e sem propriedades, encapsule 
os atributos raça e nome da mesma, tornando acessiveis
sua chamada ao serem instanciadas, teste a mesma.

*/

namespace Prova03_encapsulamento
{
    public class Animal
    {
        //Declarando os atributos raça e nome
        string raca;
        string nome;

        //Métod para informar o atributo raça
        public void setRaca(string Raca){raca = Raca;}

        //Métod para recuperar o atributo raça
        public string getRaca(){return raca;}

        //Métod para informar o atributo nome
        public void setNome(string Nome){nome = Nome;}

        //Métod para recuperar o atributo nome
        public string getNome(){return nome;}

        public Animal()
        {
        }
    }
}
