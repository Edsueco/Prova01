using System;
namespace Prova06_Cliente
{
    public class Cliente
    {
        //Declara as propriedades nome e cidade
        public string nome { set; get; }
        public string cidade { set; get; }

        //Inicializa a propriedade cidade pelo construtor
        public Cliente(string Cidade)
        {
            cidade = Cidade;
        }
    }
}
