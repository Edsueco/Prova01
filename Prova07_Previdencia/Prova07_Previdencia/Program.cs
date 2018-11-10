using System;

/* 
Nome: Eduardo Alves de Melo  07: Usando os critérios de que uma pessoa só pode se aposentar caso
seja do sexo feminino e tenha no minimo 60 anos ou ser do sexo masculino 
e possuir no minimo 65 anos, desenvolva um algoritimo usando todos os
conceitos aplicados de POO que foram desenvolvidos em sala, definindo se
a pessoa está apta ou não para adquirir tal beneficio */

namespace Prova07_Previdencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia o objeto previdencia e
            //Declara a variavel i que será utilizada no loop
            Previdencia p1 = new Previdencia();
            int i=0;

            //Loop para verificar os critérios passado pelo usuaior 
            //Testa 3 vezes
            while(i<3){
                p1.solicitaDados();
                p1.processaCriterios();
                p1.resultado();
                i++;
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
