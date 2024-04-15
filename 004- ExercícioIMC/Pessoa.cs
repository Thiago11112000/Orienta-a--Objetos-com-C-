using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Pessoa
    {
        public double peso,altura;
         
         public double calculo()
         {
         return  peso / (altura * altura);
         }

         public string situacao(double imc){
            string retorno ="null";

             if(imc < 18.5)
             {
                retorno = "Abaixo do peso";
             }
             else if(imc < 25)
             {
              retorno = "Peso normal";
             }
             else if (imc < 30)
             {
              retorno = "acima do peso";
             }
             else if (imc < 35)
             {
             retorno = "Obesidade I";
             }
              else if (imc < 49)
             {
             retorno = "Obesidade II";
             }
              else if (imc >= 40)
             {
             retorno = "Obesidade III";
             }
              return retorno;
         }
       public void mensagem()
       {
         double obterCalculo = calculo();

         string obterSituacao = situacao(obterCalculo);

         Console.WriteLine("Seu IMC é de "+obterCalculo);
         Console.WriteLine("Sua situação é "+obterSituacao);
       }
    }
