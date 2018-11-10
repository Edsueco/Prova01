using System;
namespace Prova07_Previdencia
{
    public class Previdencia
    {
        //Declara as propriedades sexo e idade
        public string sexo { set; get; }
        public int idade { set; get; }
        public string status { set; get; }

        //Cria o metodo para solicitar as informações dos usuarios e
        //armazena as informações
        public void solicitaDados(){

            Console.WriteLine("INFORME OS DADOS SOLICITADOS");
            Console.Write("IDADE: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("SEXO (M/F): ");
            sexo = Console.ReadLine();
        }

        //Metodo para calcular se os critérios informados são validas
        public void processaCriterios(){
            if(((sexo == "F"|| sexo == "f") && idade >= 60) || ((sexo == "M" || sexo == "m") && idade >= 65))
            {
                status = "Contribuinda está apto a se aposentar";
            }else{
                status = "Contribuinda não está apto a se aposentar";
            }
        }

        //Metodo para exibir o resultado
        public void resultado(){
            Console.WriteLine("Resultado: {0}", status);
        }

        public Previdencia()
        {
        }
    }
}
